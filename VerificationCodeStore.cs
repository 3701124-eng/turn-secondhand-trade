using System.Collections.Concurrent;
using System.Security.Cryptography;

namespace 转一转校园二手物品交易系统
{
    internal static class VerificationCodeStore
    {
        private static ConcurrentDictionary<string, CodeEntry> _store = new();
        private static ConcurrentDictionary<string, DateTime> _lastSent = new();
        private static readonly TimeSpan Cooldown = TimeSpan.FromSeconds(60);

        public static (string? code, string? error) Generate(string email)
        {
            if (_lastSent.TryGetValue(email, out var last) && DateTime.Now - last < Cooldown)
            {
                int remain = (int)(Cooldown - (DateTime.Now - last)).TotalSeconds;
                return (null, $"请等待 {remain} 秒后再重新发送");
            }

            string code = RandomNumberGenerator.GetInt32(100000, 1000000).ToString();
            _store[email] = new CodeEntry(code, DateTime.Now.AddMinutes(5));
            _lastSent[email] = DateTime.Now;
            return (code, null);
        }

        public static VerifyResult Verify(string email, string code)
        {
            if (_store.TryRemove(email, out var e))
            {
                if (DateTime.Now >= e.ExpiresAt)
                    return VerifyResult.Expired;
                if (e.Code == code)
                    return VerifyResult.Success;
            }
            return VerifyResult.Invalid;
        }

        public static void Invalidate(string email)
        {
            _store.TryRemove(email, out _);
            _lastSent.TryRemove(email, out _);
        }

        private record CodeEntry(string Code, DateTime ExpiresAt);
    }

    internal enum VerifyResult
    {
        Success,
        Expired,
        Invalid
    }
}
