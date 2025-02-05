# 万能文字工具箱——免费的文字处理助手
高速下载：https://www.123684.com/s/f3HzVv-rO17d


**提示：Word插件上新了**

# 一、软件介绍

本款软件基于Github上各种开源库制作而成（几乎没有什么代码研究价值），免费实现各种文字处理功能。包括OCR识别、文字转语音、词云生成、文字转拼音、翻译、分词等功能（除了翻译功能均可以离线使用）欢迎下载体验。
![已更新全新UI](https://github.com/QiBowen2008/SuperTextToolBox/blob/NewBranch/screenshots/1.PNG?raw=true)
系统要求：推荐Windows7以上，OCR需要64位系统，XP系统不支持OCR和词云，Vista我没测试。推荐安装.Net Framework 4.5.2或更高版本以使用全部功能，XP请安装4.0
# 二、功能介绍

## 1、OCR识别（64bit）（批量！）

基于[PaddleOCRSharp](https://gitee.com/raoyutian/paddle-ocrsharp)开发，拥有很高的精确度（即使是位置杂乱无章的文本）。下图为示范图
![OCR识别效果](https://github.com/QiBowen2008/SuperTextToolBox/blob/NewBranch/screenshots/6.gif?raw=true)

## 2、文字转语音

基于微软自己的System.Speech库实现，支持较多语言，同时破处了某办公软件非会员不能导出的限制。
![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/NewBranch/screenshots/4.PNG?raw=true)

## 3、词云生成

基于[WordCloudSharp](https://github.com/AmmRage/WordCloudSharp)实现，可以选择模版（目前暂时不能完全自定义）
![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/NewBranch/screenshots/7.gif?raw=true)
## 4、文字转拼音

基于[Chinese](https://github.com/zmjack/Chinese)库实现，无限制文字转拼音（解除了某办公软件非会员30个字的限制）
![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/NewBranch/screenshots/3.gif?raw=true)

## 5、翻译（在线，自己输入api）

基于百度翻译，支持上百种语言，~~未来还可以进行指定领域翻译~~（现在已经可以了）
![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/NewBranch/screenshots/2.PNG?raw=true)

## 6、分词

类似Jieba的分词功能
![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/NewBranch/screenshots/5.gif?raw=true)

## **7、Word插件（批量功能！）**

在word中直接提供以上全部功能！同时附加了一些批量（批量打印，批量输出PDF）功能，自己体验！
（WPS目前可能无法使用）

## **8、文字转图片**
文字转为图片，防止文本被篡改，可以长文本输出多张图片，自定义每张图片字数

开发这个功能还有一个故事：
我最早开始写这个功能不是为了这个软件，而是为了我们班一个特别爱看小说的同学。当时我们那边学校给我们人手发一个学生平板，可以在学校使用。当时他就用各种办法网平板上传小说，后来学校把文本通道封了，我就给他开发了这个转图片工具，可是很快被老师发现了...
他毕竟是当时全班第一的好学生，我成绩也还行没有收到太多惩罚，现在我决定改邪归正。可是，他的成绩下降了，我才想起一句话
> 要允许学生上课看小说，要允许学生上课打瞌睡，要爱护学生身体，教员要少讲，要让学生多看。 毛泽东——《与王海蓉的谈话》

![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/NewBranch/screenshots/8.PNG?raw=true)

## 附加功能：成语接龙小游戏

仔细玩一下你会发现没什么意思，不会成语一样玩。（正在修复这个Bug）
![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/NewBranch/screenshots/9.PNG?raw=true)
# 三、软件开发历程
## 创建缘由
本人来自青岛西海岸新区，初中的时候新区有好政策，试行智慧教育，给每个中小学生发了一个平板，这也是我开始一切的地方。
2022年春天，疫情反复，还在上初二的我又一次回家上了网课。闲的没事的时候翻阅平板上的电子课本，发现了一本《算法与程序设计》，没错，就是高中旧课本学VB的那本书，我就从那里学到了一些计算机程序编写技术，当时的课本没有防自学设计，所以我一个月就学了很多东西。最后我在初三前的暑假设计了软件万能计算器，之后把它开源了出来
链接：https://github.com/QiBowen2008/SuperCalc-Made-of-VB6
这个软件的唯一特色就是实现了一个带有单位转换功能的套公式计算工具，并且公式太少，后来想想要补充更多公式，结果没有时间，而且VB古老的IDE效率非常差，可以说就是一个记事本加一个资源管理器还有一个窗体设计器
初三寒假我决定寻找其他更好的开发工具，我也游荡在github学东西，顺带发现了很多第三方库，后来我通过VB.NET发现了C#，我发现C#还有很多人在使用，很多基本方法和VB一样（你要相信他们的内部原理甚至也是一样的，都是和java类似的虚拟机语言，VB有msvbvm60.dll，.NET也需要运行库）所以我决定使用C#。可是一个现实问题，那就是如何迁移代码。有一个VBtoConvert工具，我试了试，非常难用，但是我已经开发了十多个form，完全不想迁移项目，何况我是初学者。
我决定用C#开发一点不一样的东西，我发现很多OCR软件都要付费才能使用，或者需要在线使用，这让我有一个念头，想要开发一个集成了类似WPS会员功能的软件——万能文字工具箱
## 编写历程
我为了实现这个技术，找遍很多第三方库，我要OCR库，先试了试TesseractOCR，结果总是不明原因报错，后来只能牺牲32位系统，换了Padd了OCR，这也是我唯一一次信服百度的一次，让我明白百度还有良心
我还遇到很多困难，比如这个读写ini文件，读写文本文档，调用api之类的，不过幸运的是最后都解决了，最终我发布了这个软件的最初版本
后来，我利用初三结束的暑假，进一步优化了这个软件，修复了很多bug，优化了UI...
上高中之后，时间紧张，我不经常管理这个项目，结果高一的寒假我惊奇的发现这个软件多了一个star，我很高兴，决定坚持开发
高一寒假我又更新了一次，支持更多语言的OCR，压缩了软件空间，我还给软件添加了一坨标签，结果这真的有用
## 现在状态
我现在（2024.8）正是高二暑假，star数据来到了40+，我又进一步开发了word插件版本的工具箱，现在已经发布
## 未来计划
1.计划OCR增加截图识别
2.翻译计划增加领域翻译（已经实现）
3.自定义词云生成
4.修复成语接龙Bug
5.增加~~Word和~~PowerPoint插件功能（word实现了）
6.更好的支持高dpi（目前已尽力适配）
其实，这些并不一定能够实现，我还在筹划新的项目，要专门开发office插件，制作全网第一个高质量的office开源插件。
# 四、编译注意
这是4个工程，除去开发中的PowerPoint插件，你需要把四个工程的输出文件放到一个文件夹里，然后才能使用，还需要把OCR工程里的OCRModel了完全复制到文件夹里，还要把根目录的resource文件复制过去，最后别忘了根目录有4个图片也要复制进去，这样你就得到了绿色版软件
