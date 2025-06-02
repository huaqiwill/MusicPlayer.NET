# MusicPlayer.NET

一个简单的本地音乐播放器，基于.NET开发。

## 主要功能

- 🎵 本地音乐播放（支持 MP3、WAV、FLAC、OGG 格式）
- 📁 本地音乐文件选择和导入
- 📋 播放列表管理
- ⏯️ 基本播放控制（播放、暂停、下一首）
- 🔊 音量调节
- 📝 当前播放歌曲显示

## 技术栈

- .NET 8.0
- Windows Forms
- NAudio (音频处理库)
- Windows Media Player 组件
- NVorbis (OGG 格式支持)

## 系统要求

- Windows 操作系统
- .NET 8.0 Runtime
- Windows Media Player

## 项目结构

```
MusicPlayer.NET/
├── MusicPlayer/              # 主项目目录
│   ├── Form1.cs             # 主窗体和业务逻辑
│   ├── Form1.Designer.cs    # 窗体设计器代码
│   ├── Program.cs           # 程序入口
│   └── MusicPlayer.csproj   # 项目配置文件
└── MusicPlayer.sln          # 解决方案文件
```

## 开发环境配置

1. 安装 Visual Studio 2022 或更高版本
2. 安装 .NET 8.0 SDK
3. 克隆项目代码
4. 使用 Visual Studio 打开解决方案文件 (MusicPlayer.sln)
5. 还原 NuGet 包
6. 编译运行项目

## 主要依赖项

- NAudio (2.2.1)
- NAudio.Asio (2.2.1)
- NAudio.Core (2.2.1)
- NAudio.Midi (2.2.1)
- NAudio.Vorbis (1.5.0)
- NAudio.Wasapi (2.2.1)
- NAudio.WinForms (2.2.1)
- NAudio.WinMM (2.2.1)
- NVorbis (0.10.4)

## 许可证

本项目采用 MIT 许可证

## 注意事项

1. 本项目是一个基础的音乐播放器实现，主要用于演示和学习目的
2. 使用了 Windows Media Player 组件和 NAudio 库来处理不同格式的音频文件
3. OGG 格式的音频使用 NAudio 和 NVorbis 处理，其他格式使用 Windows Media Player 组件处理

## 贡献指南

1. Fork 本仓库
2. 创建特性分支 (`git checkout -b feature/AmazingFeature`)
3. 提交更改 (`git commit -m 'Add some AmazingFeature'`)
4. 推送到分支 (`git push origin feature/AmazingFeature`)
5. 提交 Pull Request

## 联系方式

如有问题或建议，请提交 Issue 或 Pull Request。 
