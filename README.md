# MusicPlayer.NET

一个功能强大的本地音乐播放器，基于.NET开发。

## 主要功能

- 🎵 本地音乐播放
- 📁 本地音乐扫描和导入
- 📋 歌单管理（创建、编辑、删除）
- ⏯️ 播放控制（播放、暂停、上一首、下一首）
- 🔄 播放模式（顺序播放、随机播放）
- ⚡ 倍速播放控制
- 🎨 美观的用户界面
- 📊 播放历史记录
- ❤️ 收藏夹功能

## 技术栈

- .NET 7.0
- WPF (Windows Presentation Foundation)
- NAudio (音频处理库)
- SQLite (本地数据存储)
- Material Design风格UI

## 系统要求

- Windows 10 或更高版本
- .NET 7.0 Runtime
- 最小内存要求：4GB RAM
- 存储空间：100MB以上（不含音乐文件）

## 安装说明

1. 下载最新版本的安装包
2. 运行安装程序
3. 按照向导提示完成安装

## 使用说明

1. 首次运行时，可以选择扫描本地音乐文件夹
2. 通过界面顶部的导入按钮可以手动导入音乐文件
3. 在左侧边栏可以管理歌单
4. 主界面显示当前播放列表和播放控制器
5. 右键点击歌曲可以进行更多操作（添加到歌单、删除等）

## 开发说明

### 环境配置

1. 安装 Visual Studio 2022
2. 安装 .NET 7.0 SDK
3. 克隆项目代码
4. 使用 Visual Studio 打开解决方案文件
5. 还原 NuGet 包
6. 编译运行项目

### 项目结构

```
MusicPlayer.NET/
├── src/                    # 源代码
│   ├── MusicPlayer.Core/   # 核心业务逻辑
│   ├── MusicPlayer.UI/     # WPF界面
│   └── MusicPlayer.Data/   # 数据访问层
├── tests/                  # 测试项目
├── docs/                   # 文档
└── tools/                 # 工具和脚本
```

## 贡献指南

1. Fork 本仓库
2. 创建特性分支 (`git checkout -b feature/AmazingFeature`)
3. 提交更改 (`git commit -m 'Add some AmazingFeature'`)
4. 推送到分支 (`git push origin feature/AmazingFeature`)
5. 提交 Pull Request

## 许可证

本项目采用 MIT 许可证 - 详见 [LICENSE](LICENSE) 文件

## 联系方式

如有问题或建议，请提交 Issue 或 Pull Request。 
