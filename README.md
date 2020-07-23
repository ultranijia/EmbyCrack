# EmbyCracked

## Feature
+ 破解 Emby 高级版验证
+ 修改了默认插件源，加速中国用户下载插件
+ docker 一键安装

## Usage

### 手动替换
+ **注意**：如果以前使用其他破解方案，必须将系统的 hosts 的 mb3admin.com www.mb3admin.com 条目删除，否则破解不会生效
+ 将 [破解程序集](https://github.com/YukiCoco/EmbyCrack/tree/master/assembly) 替换原有文件即完成破解，原有文件路径为 `system/System.Net.Http.dll`
+ 客户端使用:
  + 浏览器：安装 [URLRedirector]() 插件，将 `https://mb3admin.com` 替换为 `http://crackemby.neko.re`
  + Android & Android TV：直接使用破解版，自己找找就有了  
+ 详细使用方法移步[这里](https://neko.re/archives/128.html)

### 使用 Docker
+ `yukinococo/emby_crack:unix-x64`（Unix）
+ `yukinococo/emby_crack:windows-x64` （Windows）
