SET PATH=%PATH%;C:\Windows\Microsoft.NET\Framework\v1.2.21213
csc.exe /r:"C:\Windows\Microsoft.NET\Avalon\ShellInterop.dll" /r:"C:\Windows\Microsoft.NET\Avalon\System.Windows.dll" /r:"C:\Windows\Microsoft.NET\Avalon\Microsoft.Windows.Client.dll" /out:"%USERPROFILE%\Desktop\privacy.exe" privacy.cs
