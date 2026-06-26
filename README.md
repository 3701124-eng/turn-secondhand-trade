# -
.net课程结课作业

## SMTP 邮箱配置（组员必看）

系统使用邮箱发送验证码实现密码重置功能，需要自行配置 SMTP 信息。

### 配置步骤

1. 在项目根目录新建 `AppSettings.secret.config` 文件
2. 粘贴以下内容，替换成你自己的 QQ 邮箱和授权码：

```xml
<?xml version="1.0" encoding="utf-8"?>
<appSettings>
  <add key="SmtpHost" value="smtp.qq.com"/>
  <add key="SmtpPort" value="587"/>
  <add key="SmtpUser" value="你的QQ邮箱@qq.com"/>
  <add key="SmtpPass" value="你的QQ邮箱授权码"/>
  <add key="SmtpFrom" value="你的QQ邮箱@qq.com"/>
</appSettings>
```

3. **获取授权码**：登录 QQ 邮箱 → 设置 → 账户 → 开启 POP3/SMTP 服务 → 按提示发送短信 → 获得 16 位授权码
4. 将授权码填入 `SmtpPass` 的值中
5. 保存文件后运行即可

> ⚠️ 此文件已加入 `.gitignore`，不会被提交到 GitHub，请放心填写真实信息。
