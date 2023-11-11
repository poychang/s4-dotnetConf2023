﻿using dotnetConf2023.Shared.Models;

namespace dotnetConf2023.Shared.Services
{
    public class SpeakerService
    {
        public IEnumerable<SpeakerModel> GetSpeakers()
        {
            var speakers = new List<SpeakerModel> {
                new SpeakerModel {
                    Id = "Will Huang",
                    Name = "Will Huang",
                    JobTitle = "多奇數位創意 技術總監",
                    PictureUrl ="./img/speakers/Will 保哥.jpg",
                    BlogUrl = "http://blog.miniasp.com/",
                    FacebookUrl = "https://www.facebook.com/will.fans/",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "現任「多奇數位創意有限公司」技術總監。2018 年榮獲 Angular 方向的 Google Developer Expert (GDE) 開發專家。連續 16 度當選微軟最有價值專家(MVP)。2019 獲選微軟技術社群區域總監 (Microsoft Regional Director)。熟悉 Angular、JavaScript、.NET、C#、ASP.NET MVC、Go、Docker、Kubernetes 相關技術。擅長 DevOps 與組織文化建立、軟體團隊建構與管理。熱愛分享知識。",
                    Topic = "ASP.NET Core 8.0 全新功能探索",
                    TopicOutline = "TBD",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "David Tung",
                    Name = "David Tung",
                    JobTitle = "光岩資訊資深技術顧問",
                    PictureUrl ="./img/speakers/David Tung.jpg",
                    BlogUrl = "http://studyhost.blogspot.tw/",
                    FacebookUrl = "http://www.facebook.com/DotNetWalker/",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "光岩資訊資深技術顧問、歷屆微軟 TechDays、TechED 研討會講師、連續 14 年榮獲微軟最有價值專家 (MVP)、LINE API Expert(LAE)，專長領域跨及.NET開發技術、Azure DevOps、AI、ChatBot...熟悉 BPM、APS、ERP…等企業應用資訊系統之建置與導入。David 是敏捷開發與 DevOps 的熱愛者，打從 Apple II 時代開始闖蕩江湖至今，在資訊業各領域均有參與。做過 MIS/IT、當過 RD、帶過專案、團隊、也賣過軟體，寫過（這年頭已經消失了的）雜誌專欄、長年擔任企業訓練講師與顧問，出過一堆書……打從沒有物件導向，沒什麼所謂軟體生命週期管理的年代，一路經歷了無數個壯觀的大小瀑布與千瘡百孔的雷與坑、一直到今天，依舊還是一個喜歡寫 Code 的人...",
                    Topic = "TBD",
                    TopicOutline = "TBD",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Edward Kuo",
                    Name = "Edward Kuo",
                    JobTitle = "Microsoft Regional Director",
                    PictureUrl ="./img/speakers/Edward Kuo.jpg",
                    BlogUrl = "https://profile.edwardkuo.dev/",
                    FacebookUrl = "https://www.facebook.com/groups/286316594814216/",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "是 Enterprise IT Manager、 Microsoft Regional Director、Microsoft Azure MVP & Speaker 在不同的角色中學習用不同觀點看待軟體開發流程，不僅熱愛技術，也喜愛探索商業需求，在需求與技術探尋合適的解決方案。現在主要專注於雲端系統架構設計、工業 4.0 以及 AI 解決方案架構與導入，並指導企業建置的 DevOps 開發與維運流程。",
                    Topic = "組合 Azure PaaS 的應用與看法",
                    TopicOutline = "在追求提高效能、節省成本和提高可用性的目標下，許多公司已經踏上將資料和應用程式遷移到雲端的旅程。擁抱雲端成為各大企業近年來的轉型目標之一。若在擁抱雲端的過程中猶豫不決，不知道是該使用 PaaS 還是 IaaS，可以參加這個議程，作為選擇的參考。同時，本議程還將呈現某企業實際的架構，闡述PaaS所帶來的效益。除了架構的轉變，IT 人員還需轉向雲原生的設計思維。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Andrew Wu",
                    Name = "Andrew Wu",
                    JobTitle = "91APP 首席架構師",
                    PictureUrl ="./img/speakers/Andrew Wu-3.jpg",
                    BlogUrl = "https://columns.chicken-house.net/",
                    FacebookUrl = "https://www.facebook.com/andrew.blog.0928/",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "現任 91APP 首席架構師，專長領域為軟體工程、物件導向設計、分散式系統架構設計、平行處理、API 設計及微服務導向架構設計（microservices）等。具 23 年 Microsoft .NET Framework、SaaS、B2B2C 等雲端服務開發經驗，喜歡研究各種技術背後的原理與實作細節。現任職之 91APP 為台灣首間上櫃之 SaaS 服務商，具逾500人的營運團隊，為零售產業數位轉型的軍火庫，提供企業級軟體雲產品到品牌經營顧問之服務。Andrew 樂於分享技術新知與開發經驗，除了時常出席各大技術研討會與社群活動外；也不時更新部落格文章，與夥伴們交流與傳承經驗，深信自我精進源自分享，這也是 20 年持續筆耕不輟的動力。",
                    Topic = "TBD",
                    TopicOutline = "TBD",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Bruce Chen",
                    Name = "Bruce Chen",
                    JobTitle = "Kingston Senior Engineer",
                    PictureUrl ="./img/speakers/Bruce Chen.jpg",
                    BlogUrl = "https://blog.kkbruce.net/",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "任職於全美前 50 大私人企業，連續 12 年榮獲微軟最有價值專家，負責大型 B2B 資料交換、Web API 架構、Docker、Kubernetes 等系統平台架構與設計。由 ASP.NET 2.0(WebForms) 進入 .NET 的世界，喜歡分享心得於 blog.kkbruce.net 部落格，瀏覽量超過七百萬。合著作品有《ASP.NET MVC4 網站開發美學》、《ASP.NET MVC 5網站開發美學》；合譯作品《Martin Fowler 的企業級軟體架構模式》。經常於社群與研討會分享 .NET 開發與容器平台經驗，對於 ASP.NET Web API 框架有深入研究，是台灣宣導 ASP.NET Web API 的先驅。",
                    Topic = "Visual Studio 2022 開發工具大補帖",
                    TopicOutline = "地表最強開發工具 Visual Studio 並不會因為它是最強就停止它成長。可惜的是，開發人員只專注在編輯器畫面裡敲打程式碼，並沒有發揮出 Visual Studio 所帶來的強大的功能。近期 Visual Studio 對於 Web API 開發工具進行多項的改善升級，讓 Web API 的開發人員有更為愉悅的的開發體驗。因此，本場次將深入淺出介紹 Visual Studio 為 Web API 新帶來 .http 功能，讓 .http 為您的 Web API 品質加分。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Kevin Yang",
                    Name = "Kevin Yang",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/Kevin Yang.jpg",
                    BlogUrl = "https://blog.kevinyang.net/",
                    FacebookUrl = "https://www.facebook.com/CKNotepad/",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "目前擔任 Angular Taiwan、Angular Girls Taiwan 、TypeScript Taiwan 社群管理者，Angular 線上讀書會主持人。2018 年榮獲 Angular/Web GDE (Google Developer Expert) 開發專家。微軟最有價值專家 (Visual Studio and Development Technologies)。熱衷分享任何新奇的技術資訊、不務正業(跨領域)，目前已跨入的領域有會計、醫療資訊及程式開發。",
                    Topic = "有在關注 AOT 嗎？ You Should",
                    TopicOutline = "有寫過 Go 的人應該知道 Golang compile 出來的檔案是不需要透過 language runtime 就可以執行，這樣的好處在 Cloud native 的世界裡真的很吃香，對比於其他 rumetime compile 的語言，例如 Java、.NET，Image size 隨便都 200 MB 起跳。 AOT 在 .NET 的世界裡不是第一次提出，但 .NET 8 是正式看待這件事情，就讓我們來看看 AOT 在 .NET 8 可以做到怎樣的程度。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Jimmy Ho",
                    Name = "Jimmy Ho",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/Jimmy Ho.jpg",
                    BlogUrl = "https://jiaming0708.github.io/",
                    FacebookUrl = "https://www.facebook.com/secretgogoworld",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "一個熱愛學習、分享並且近期狂點前端技能樹的小小工程師，什麼都會什麼都不奇怪。",
                    Topic = "徹底搞懂 Blazor 的 Service Worker 機制",
                    TopicOutline = "在 Blazor WebAssembly 中開啟 PWA 的模式，讓服務可以離線工作載入，也可以接收從伺服器端發出的訊息，更可以在背景更新以上所說到的行為，到底是怎麼運作的，有沒有什麼要額外注意的地方，讓我們一次搞清楚。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Gelis Wu",
                    Name = "Gelis 吳俊毅",
                    JobTitle = "資深 .NET 技術顧問 & Microsoft MVP 連續七屆",
                    PictureUrl ="./img/speakers/Gelis Wu.jpg",
                    BlogUrl = "http://gelis-dotnet.blogspot.com/",
                    FacebookUrl = "https://www.facebook.com/groups/361804473860062/",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "我目前是個軟體生命週期導入專業顧問<br/>我專精於顧問與協助企業流程改造(電子化)協助將商業邏輯服務化、彈性化: 以 SOA 服務導向架構的方式提供 API 框架，讓各應用程式在開發時容易調用，加速開發、並可提高商業邏輯的再利用率，協助呈現介面多元化等。同時也擅長協助提升企業的軟體專案開發與工作效率，協助企業內部制定開發團隊流程 (Coding Rule/Standard) 與技術一致化，統一開發環境與技術、應用協同工作平台 Azure DevOps 建置雲端相關應用、自動化部署工具評估與導入。<br/>同時因為專案開發出身，我同時也擅長協助企業建置 ERP/CRM/CMS 或企業內部 EIP 等相關系統。",
                    Topic = "Blazor in .NET 8 的重大改變",
                    TopicOutline = "● 初探 Blazor in .NET 8<br/>● 全新範本 Blazor United Project (Web App)<br/>&nbsp;&nbsp;&nbsp;&nbsp;- 統一所有 Blazor 開發的全新樣板<br/>&nbsp;&nbsp;&nbsp;&nbsp;- 有那些東西不見？<br/>● Server-side Rendering 與 Streaming Rendering<br/>● 如何開始 & 如何進行商用開發？<br/>● 如何將 Blazor in .NET 6/7 移轉至 .NET 8<br/>&nbsp;&nbsp;&nbsp;&nbsp;- 案例介紹：將 .NET 6 的 BlazorApp 無痛升級到 .NET 8",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Bao Chengyou",
                    Name = "鮑承佑",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/鮑承佑.jpg",
                    BlogUrl = "https://linktr.ee/windperson",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "本人於 2007 年底投身資訊業，從原本寫 Java， 2009 年開始接觸 WPF、Silverligh t的 C# 桌面應用程式開始投入 .NET開發，之後於資拓宏宇擔任軟體專案工程師，於 2014 年投入遊戲業在台灣卡普空擔任開發組組長，2018 到2023 上半在XR領域相關新創擔任 CTO；Unity, Xamarin/MAUI, ASP.NET Core, Blazor, Azure SignalR 等前後端與Azure雲端開發技術都略懂略懂，但抓 bug 比較在行。",
                    Topic = "除了刻鋼板表單 CRUD 懂 C# 也能打造美幻 3D",
                    TopicOutline = "本議程介紹三個可用 C# 進行開發的 3D 遊戲/應用開發引擎：Unity、Godot 和 Stride Engine。Unity 是跨平台遊戲引擎，可輕鬆地創建 2D 和 3D 遊戲或應用。Godot 是臉書支持的 MIT 授權免費開源遊戲引擎，也支持使用 C# 進行程式撰寫。Stride Engine 是 MIT 授權開源 3D 跨平台遊戲引擎，使用 .NET 6 C# 開發，可讓開發者以 C# 10 的語言規格撰寫遊戲或商業應用。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Yin Sangzhi",
                    Name = "尹相志",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/尹相志-AI.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "於 2002 年台灣創立 asiaMiner 為台灣第一家專業大數據顧問公司。2015 年正式擔任中國第一家大數據顧問公司華院數據的首席數據科學家，並於 2016 年發起中國首次人工智能大賽 BOT (Brain of things) 2016，目前於大陸成立 Deepbelief.ai 聚焦於機器視覺的創新商業應用。",
                    Topic = "榨出大型語言模型最大潛力的 Prompt 思考術",
                    TopicOutline = "ChatGPT 運用了思維鍊，大幅提升了面對到複雜的問題的解題能力，而後思維樹、思維圖乃至於 ReAct、自我批評等技巧更是擴展了大型語言模型的無限可能。在這個 Session 將會介紹思考術相關概念以及如何使用 Azure OpenAI Service 來實現。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Ian",
                    Name = "Ian Chan",
                    JobTitle = "微軟最有價值專家",
                    PictureUrl ="./img/speakers/Ian.jpg",
                    BlogUrl = "https://medium.com/playtech",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "https://www.linkedin.com/in/codeian/",
                    Introduction = "陳葵懋（Ian Chen），連續12年當選微軟最有價值專家(MVP/現為AI領域)，同時也是連續5年微軟認證講師（MCT）。<br/>目前任職於「一等一科技股份有限公司」，熟悉 .NET 開發、Azure 雲端，近年來專注於Azure Devops、K8s、OpenAI等技術<br/>，相信持續學習與分享能成長與收獲的更多，曾擔任微軟 TechDays、Devdays Asia 、Mopcon、Modern Web Conference等研討會講師。<br/>2023年策畫與共同著作第一本講述Azure OpenAI 的技術書籍：駕馭 ChatGPT 4: 探索 Azure OpenAI 與 Cognitive Service for Language 開發實踐 （使用 .NET 與 Node.js）。。",
                    Topic = ".NET x AI，基於開源的「Semantic Kernel 」SDK 建構大型自然語言 (LLM) 生成式 AI 應用",
                    TopicOutline = "生成式 AI 應用的誘發劑是 Prompt，因此提示工程（Prompt Engineering）成為炙手可熱的議題，然而從開發層面來看，實作一個真實場景的生成式應用，<br/>除了 Prompt 之外往往會遇面臨到如何處理上下文記憶、Few-Shot、Embeddings、Plugins 等機制的整合，當然神人可以全面自已來實現，而凡人的你我不<br/>用現成解決方案就太對不起自已啦。<br/>Semantic Kernel 是 Microsoft 在打造 GitHub Copilot、M365 Copilot、Bing Chat 所用的核心，現已開源是一個輕量化的 SDK 且即將正式迎來 1.0 版本，<br/>它支援 C#、Python、Java、TypeScript 程式語言，將開發生成式 AI 應用以 Pipeline 概念展開，提供一個生成式 AI 應用開發 Pattern。<br/>本場次除了帶大家來認識 Semantic Kernel 之外，我也將示範如何使用 Semantic Kernel，融合 GPT 模型，透過 Prompt 及 Plugin，打造生成式 AI 應用。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "KO KO",
                    Name = "KO KO",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/KO KO.jpg",
                    BlogUrl = "",
                    FacebookUrl = "https://www.facebook.com/magic.panda.engineer/",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "Ko Ko 是一位資深的軟體工程師，也連續四年獲得微軟 AI 領域的最有價值專家（Microsoft AI MVP）獎項。他擔任許多技術年會的講者，包含了 COSCUP、ModernWeb、名古屋開源年會、香港開源年會、PyCon APAC、PyCon HK、DevDays Asia 等等的大型年會，累計已超過萬名聽眾。共同著作有《駕馭 ChatGPT 4: 探索 Azure OpenAI 與 Cognitive Service for Language 開發實踐 (使用. NET 與 Node. Js)》一書，拿過天瓏書局暢銷排行榜第二名。經營臉書粉專「大魔術熊貓工程師」。Ko Ko 所撰寫系列文章「一起學習 Azure Machine Learning」是繁體中文圈關於 Azure Machine Learning 最完整的學習資源之一。",
                    Topic = "在 Azure Machine Learning 上學習 LangChain",
                    TopicOutline = "LangChain 是開發大語言模型應用最主流的框架之一，其簡單好上手的特性，讓開發者可以快速打造產品的原型。而 Azure Machine Learning 目前做 AI 研究與應用開發最主流的工具之一。其完整的功能以及和 Python 與 AI 相關的生態系整合相當完整。<br/>本次演講會為大家介紹 LangChain 的基本概念，包含 Model、Chain、Retriever 等重要元件，並且使用 Azure Machine Learning 上的功能做為範例。此外還會介紹如何把 LangChain 整合進到 Azure Machine Learning 裡面。讓開發者可以利用 Azure Machine Learning 的優勢，快速打大語言模型的應用程式。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "JiaSin",
                    Name = "陳佳新",
                    JobTitle = "奇步應用有限公司 執行長",
                    PictureUrl ="./img/speakers/陳佳新.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "具備 LINE API Expert 及 Microsoft AI MVP 專家資格，推廣 Chatbot 聊天機器人及 AI 人工智慧技術落地不遺餘力，目前是中部人的聊天機器人小小聚、彰化 AMA 小聚、彰化 Google 技術開發者社群的主辦人，致力於提升故鄉彰化乃至中部地區的數位化能力，同時也是「彰化旅行+」的核心成員，來彰化吃喝玩樂歡迎指名！",
                    Topic = "從 GPT 到 DALL·E：在 Azure 上實現 AI 的創造性應用",
                    TopicOutline = "我將帶領大家進入 Azure OpenAI 的世界，探索如何將 GPT 和 DALL·E 這些前瞻技術融入 .NET 應用開發。我們將深入了解這些強大工具如何助力創造性思維，並透過實際案例展示 AI 如何在各行各業推動創新，從自動化的文字生成到革命性的影像創作。一起來領略 AI 如何擴展 .NET 開發的新視野吧～",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "RyanChung",
                    Name = "Ryan Chung",
                    JobTitle = "Microsoft MVP",
                    PictureUrl ="./img/speakers/Ryan Chung.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "Ryan Chung，行動開發學院創辦人，曾獲微軟人工智能大賽特別獎、Udacity AI 產品經理微學位。目前為美國 Pluralsight 認證講師、中央大學 AI 學程兼任講師、元智大學資工系兼任助理教授級專業技術人員。專長於 Web/App 應用開發、企業 AI 加值導入、微軟 OpenAI 與認知服務應用整合。2022 年起，獲選為微軟 MVP - AI 人工智慧最有價值專家。共同著作：駕馭 ChatGPT 4: 探索 Azure OpenAI 與 Cognitive Service for Language 開發實踐（使用 .NET 與 Node.js）。",
                    Topic = "有沒有一種可能，你需要的只是Azure AI 而不是 OpenAI",
                    TopicOutline = "隨著大型語言模型的功能日新月異，在令人讚嘆的驚呼聲中，其實裡面藏了許多\"並非\"一定要大型語言模型不可的功能。本場次想要與你一起談談那些 Azure AI 底下的好用服務。說不定，你需要的只是Azure AI。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Summit",
                    Name = "孫玉峰",
                    JobTitle = "台灣角川 數據架構師",
                    PictureUrl ="./img/speakers/孫玉峰.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "在多個產業開發各種資料產品，包含推薦系統以及廣告數據平台，近年來的公開演講以及實務上則專注在資料工程與 MLOps 的建立，期望讓數據驅動（Data-Driven）的觀念帶動各個產業領域的創新。<br/>在東吳及師大擔任業界講師，亦接受過各媒體專訪，目前也是微軟 AI 領域最有價值專家（MVP）以及 Taiwan R User Group（常態活動 MLDM Monday 主辦單位）的共同主持人。",
                    Topic = "TBD",
                    TopicOutline = "TBD",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Alan Tsai",
                    Name = "Alan Tsai",
                    JobTitle = "微軟最有價值專家",
                    PictureUrl ="./img/speakers/Alan Tsai.jpg",
                    BlogUrl = "https://blog.alantsai.net/",
                    FacebookUrl = "http://fb.alantsai.net/",
                    TwitterUrl = "http://twitter.alantsai.net/",
                    LinkedinUrl = "http://linkedin.alantsai.net/",
                    YouTubeUrl = "http://yt.alantsai.net/",
                    Introduction = "深耕 .NET 軟體開發多年，深信使用的技術不是重點，重點在於如何全面的思考並且用適合的技術解決客戶的問題，為現任的微軟最有價值專家（Microsoft MVP）- Azure，微軟認證講師（MCT），樂於分享，深信教就是最好的學習方式，定期發佈部落格（Alan Tsai 的學習筆記）文章、影片、演講分享或者幫忙翻譯。很宅，除了上班之外會出去應該都是參加/協助社群活動（Azure Taiwan），為現任 Study4.TW 成員之一。除了程式以外，就愛看小說。",
                    Topic = "探索 API 開發的挑戰與解決之道",
                    TopicOutline = "相信大家對於為什麼要把服務 API 化的原因都清楚了，但是該怎麼開始呢？如果要走 API Design First 那怎麼可以產生出好持續維護的 OpenAPI (Swagger) 文件作為溝通的 Contract 呢？API 開發完上線之後怎麼能夠確保安全，以及出錯如何追蹤問題呢？如果只是單純的 DB 異動的 CRUD 需要建立後端 API 嗎？隨著 API 數量變多怎麼收攏所有有提供的 API 呢？<br/>在這場，我們來看一下針對一些 API First 遇到的問題，微軟提供了那些解決方案給我們。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Alan Tsai",
                    Name = "Alan Tsai",
                    JobTitle = "微軟最有價值專家",
                    PictureUrl ="./img/speakers/Alan Tsai.jpg",
                    BlogUrl = "https://blog.alantsai.net/",
                    FacebookUrl = "http://fb.alantsai.net/",
                    TwitterUrl = "http://twitter.alantsai.net/",
                    LinkedinUrl = "http://linkedin.alantsai.net/",
                    YouTubeUrl = "http://yt.alantsai.net/",
                    Introduction = "深耕 .NET 軟體開發多年，深信使用的技術不是重點，重點在於如何全面的思考並且用適合的技術解決客戶的問題，為現任的微軟最有價值專家（Microsoft MVP）- Azure，微軟認證講師（MCT），樂於分享，深信教就是最好的學習方式，定期發佈部落格（Alan Tsai 的學習筆記）文章、影片、演講分享或者幫忙翻譯。很宅，除了上班之外會出去應該都是參加/協助社群活動（Azure Taiwan），為現任 Study4.TW 成員之一。除了程式以外，就愛看小說。",
                    Topic = "從 GitHub Copilot 到 Enterprise Copilot：打造符合企業需求的智能開發助手之路",
                    TopicOutline = "隨著 ChatGPT 的崛起，Generative AI 已經變得非常普遍。GitHub Copilot 是針對工程師在這一浪潮誕生的強大工具。<br/>如果你曾使用過 GitHub Copilot，你一定會對它的「讀心」功能感到驚奇。然而，它並不總能完美地滿足我們的需求。但只要我們理解它的運作原理，我們可以透過不同的方式，使其產生符合我們需求的程式碼。<br/>然而，要讓整個企業充分受益，不僅需要了解Copilot的運作方式，還需要確保生成的程式碼符合特定的企業規範和風格。這正是為什麼 Copilot Stack 這一整套解決方案應運而生，它使我們能夠開發出符合企業需求的 Copilot。<br/>在本次分享中，我們將探討GitHub Copilot 的重要性，並深入研究如何開始打造符合企業需求的 Copilot。我們將了解如何結合Semantic Kernel、Azure Prompt Flow和Visual Studio Code，以建立一個符合內部規範的 Copilot，並推動智能開發助手的進一步應用和發展。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Marcus",
                    Name = "Marcus Tung",
                    JobTitle = "微軟最有價值專家",
                    PictureUrl ="./img/speakers/Marcus Tung.jpg",
                    BlogUrl = "https://marcus116.blogspot.com/",
                    FacebookUrl = "https://www.facebook.com/marcus.tung.3",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "現任微軟最有價值專家（Developer Technologies）和 DevOps Taiwan 技術社群志工，樂於研究與分享 後端技術，將學習與實踐的心得記錄在個人部落格 m@rcus 學習筆記上，並於粉絲團不定期分享技術開發與 Observability 相關新知。",
                    Topic = ".NET 8 x OpenTelemetry ",
                    TopicOutline = "OpenTelemetry 是雲原生基金會(CNCF)推出 Kubernetes 之外的最熱門的開源專案之一，它整合 OpenTracing 和 OpenCensus 成為從應用程式收集遙測數據的新標準。此議程將探討 .NET 8 如何擁抱 OpenTelemetry，實現了日誌和指標的全面擴展，並且如何遵循 OpenTelemetry Semantic Conventions 來優化應用程式的遙測實踐。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Mike",
                    Name = "黃升煌 Mike",
                    JobTitle = "微軟最有價值專家",
                    PictureUrl ="./img/speakers/Mike.jpg",
                    BlogUrl = "https://wellwind.idv.tw/blog/",
                    FacebookUrl = "https://www.facebook.com/fullstackledder",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "目前是 Microsoft MVP 及 Angular，熟悉 .NET WebAPI 與 Angular 開發技術，主要於個人部落格分享學習知識，並活躍於 Angular Taiwan Facebook 社團。",
                    Topic = "無密碼時代降臨！使用 Passkeys 打造無密碼驗證服務",
                    TopicOutline = "在這個數位時代，資安事件層出不窮，密碼外流事件頻傳，傳統的密碼登入方式已經不再安全，或只能用更複雜的密碼，想辦法降低攻破難度，我們迫切需要一種更安全的解決方案。<br/>幸運的是，現在我們有了一個令人振奮的解決方案 - Passkeys！FIDO 聯盟推出的 Passkeys 規格，將完全改變我們登入的方式。現在，使用者不再需要記住繁瑣的密碼，只需擁有自己的 Passkey，就能輕鬆完成驗證。同時，這也意味著網站管理者不再需要儲存使用者的密碼，消除密碼外洩以及釣魚網站帶來的風險。<br/>本次分享將帶您深入探索 Passkeys 的原理，並透過實際的程式碼示範，展示如何實現 Passkeys 驗證服務。讓我們一同踏入安全的無密碼時代，探索未來資安的新里程碑！",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Bill Chung",
                    Name = "Bill Chung",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/Bill Chung.jpg",
                    BlogUrl = "https://www.dotblogs.com.tw/billchung",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "一個單純喜歡說故事的人。",
                    Topic = "歷史上的今天，變化多端的 C#",
                    TopicOutline = "TBD",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "JamesTsai",
                    Name = "James Tsai",
                    JobTitle = "骨架資訊有限公司 技術總監",
                    PictureUrl ="./img/speakers/James Tsai.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "現任 Microsoft MVP - Developer Technologies (2015~) 與 骨架資訊有限公司的技術總監。從 10 年多前開始接觸 .NET 程式開發後，經歷過撰寫各家行動平台的 App 與 Azure 雲端應用服務整合。Blog: https://xamarintech.blogspot.tw 與點部落: https://dotblogs.com.tw/jamestsai，內容涵蓋 Xamarin、Azure 服務與 Microsoft 365 的 Intune 相關應用等開發紀錄。並持續經營當前台灣最活耀的 Xamarin 社群 (Facebook 社群名稱: Xamarin Asia Developers)，與專注於跨平台應用開發與 CI/CD 整合、企業行動化資料保護…等的技術的研究與推廣。",
                    Topic = "從 Xamarin 到 .NET MAUI的全平台領域展開",
                    TopicOutline = "在Xamarin 帶給 .NET 開發人員跨平台開發行動應用的體驗後，微軟進一步的推出 .NET MAUI 技術，更在 .NET 8 中讓 .NET 開發人員能穩步地的透過 .NET MAUI 進行 Mobile 應用、桌面應用的全平台領域開發。<br/>本議程將介紹 .NET 8 帶來 .NET MAUI 的新優勢，並對比 Xamarin 與 .NET MAUI 間的設計差異。讓曾運用 Xamarin技術開發的 App去了解如何遷移到 .NET MAUI技術上，透過 .NET MAUI 更進一步的在各平台與裝置上，盡情揮灑創意與能力，開發出絕佳的前端原生應用程式。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Phi",
                    Name = "黃秉鈞",
                    JobTitle = "台灣微軟 Azure 資深雲端解決方案架構師",
                    PictureUrl ="./img/speakers/Phi.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "現於 Microsoft 擔任 Azure 資深雲端解決方案架構師，同時也是台灣唯一 CNCF Ambassador。曾任職於 Red Hat 及 VMware 擔任資深售前架構師之職，且具備 7 年以上的 IT 企業級基礎架構設計經驗。基於開源文化薰陶之下，對 Linux / Kubernetes / 雲地混合網路架構皆有技術琢磨及見解，且跟隨開源回饋的精神，將相關的知識以文章撰寫分享 (blog.pichuang.com.tw) 或於 Cloud Native Taiwan User Group 社群進行演講，相信透過開源技術和社群的力量，期望能夠幫助更多企業和使用者實現目標。",
                    Topic = "TBD",
                    TopicOutline = "TBD",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Weithenn",
                    Name = "王偉任",
                    JobTitle = "Micron - IT Staff Architect",
                    PictureUrl ="./img/speakers/Weithenn.jpg",
                    BlogUrl = "https://www.weithenn.org/",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "連續十二年成功獲選 Microsoft MVP 和 VMware vExpert 技術專家，並長期擔任網管人雜誌技術專欄作家，曾任 Modern Web Conference 2023、Kubernetes Summit 2023、COSCUP 2023、Cloud Summit Taiwan 2023、Kubernetes Summit 2022、DevOpsDays Taipei 2022、Cloud Edge Summit Taiwan 2022、SRE Conference 2022……等研討會講師，專長為打造 SDDC 軟體定義資料中心、HCI 超融合解決方案、IaC 基礎架構即程式碼環境……等，著有微軟 S2D 軟體定義儲存技術實戰……等共 19 本著作。",
                    Topic = "AKSEE (Azure Kubernetes Service Edge Essential) 超輕量容器平台",
                        TopicOutline = "在現今物聯網 (IoT) 和邊緣運算 (Edge Computing) 應用環境中，通常都是使用非常微型的硬體裝置，舉例來說，硬體裝置的記憶體可能就只有 8GB 或 16GB。此外，企業或組織的管理人員，雖然能夠針對硬體資源低的邊緣裝置運作單一應用的容器，但是必須自行打造和管理容器平台、版本、更新、維護……等作業，一旦數量過多時便會造成企業或組織管理人員的嚴重負擔。<br/>在本議程中，將為與會人員簡介說明，如何部署超輕量級的 AKSEE (Azure Kubernetes Service Edge Essential) 容器平台，以便快速部署和應用於物聯網和邊緣運算環境中，並實際展示和實作演練，如何選擇整合 K8s 或 K3s 的 Kubernetes 平台，以及實際部署雲原生的 Linux 容器和 Windows 容器。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "hwchiu",
                    Name = "邱宏瑋",
                    JobTitle = "Microsoft MVP",
                    PictureUrl ="./img/speakers/hwchiu.png",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "目前擔任微軟 MVP (Cloud and Datacenter Management), Cloud Native Taiwan User Group 志工; 喜愛撰寫部落格分享技術，參加鐵人賽並出版 Kubernetes 相關書籍，亦有開設 Kubernetes 線上課程並經營個人 粉絲團 定期分享 Cloud Native 相關新知",
                    Topic = "TBD",
                    TopicOutline = "TBD",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Roberson",
                    Name = "Roberson Liou",
                    JobTitle = "Microsoft MVP",
                    PictureUrl ="./img/speakers/RobersonLiou.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "現任微軟最有價值專家（Developer Technologies），也是 twMVC 及 DevOps Taiwan 的社群志工。<br/>喜歡參加社群的技術交流活動，並不定期在部落格（工程良田的小球場）上記錄自己踩坑的一些心得。",
                    Topic = "Deploy Azure Function with KEDA on AKS",
                    TopicOutline = "本次議程將分享如何將 Azure Function 以容器化的方式運行在 AKS 之上，以及在跨團隊的協作下，該如何將其整合至 Pipeline 之中運行。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "LinZhengxiang",
                    Name = "林正祥",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/林正祥.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "樂於研究與分享新技術，喜歡使用各項網頁技術解決各項問題。主要專研 .NET 相關 Solution 為主，以及 Angular & Vue.js 等前端技術，並在第十二屆 iT 邦幫忙鐵人賽中的 Modern Web 組獲得佳作。於 2022 年出版 ASP.NET Core 6 實戰守則：超易懂的跨平台開發入門教學，並榮登天瓏年度排行第二名",
                    Topic = "Entity Framework Core 8：創新與優化",
                    TopicOutline = "EF Core 8 推出了許多新的功能，包含了增強對 JSON 的支援、List.Contains、變更追蹤及延遲載入的增強….等，並提升效能。本次議程將快速帶大家了解這次更新帶來了哪些優化與新功能",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "JimmyLiao",
                    Name = "Jimmy Liao",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/JimmyLiao.jpg",
                    BlogUrl = "https://jimmyliao.net/",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "https://www.linkedin.com/in/jimmyliao/",
                    Introduction = "曾任職於 Microsoft/InfuseAI/Appier/IBM 。專業技能橫跨應用程式、手機應用、廣告投放、機器學習專案開發，近期致力於 Generative AI、LLM 相關應用開發推廣，協助客戶技術概念落實，以及技術諮詢。<br/>日常生活就是跑步，雖然完成 15 場全程馬拉松，但是還是朝著 Sub-4 的目標努力中。聲明：內容只代表個人意見/血淚史，不代表曾任職公司的立場。",
                    Topic = "Build Generative AI Applications With Prompt Flow and Assistants API",
                    TopicOutline = "Agenda:<br/>- Introduction, Usage<br/>- Evaluate and Improve<br/>- Dev/Build<br/>- Monitor in production",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "Dann",
                    Name = "吳典璋",
                    JobTitle = "Build School 軟體工程師培訓學校創辦人",
                    PictureUrl ="./img/speakers/Dann.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "軟體及網路領域工作經驗，曾任職於微軟Microsoft，歷經技術工程師、業務、產品行銷，熟悉軟體開發之行銷及技術推廣，如.NET、Cloud/Azure 等，是一位熱情及樂於分享之軟體資訊愛好者",
                    Topic = "TBD",
                    TopicOutline = "TBD",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },
                new SpeakerModel {
                    Id = "YvonneShih",
                    Name = "Yvonne Shih ",
                    JobTitle = "台灣微軟 雲端解決方案架構師",
                    PictureUrl ="./img/speakers/Yvonne Shih.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "Yvonne Shih 專注於 Azure 上的 Data & AI 技術，並基於 Azure 上的服務和合作夥伴協作開發更多解決方案。",
                    Topic = "TBD",
                    TopicOutline = "TBD",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2021, 12, 17, 13, 0, 0),
                    SessionEnd = new DateTime(2021, 12, 17, 17, 30, 0),
                    IsShow = true,
                    Tags = new string[]{ "MS", "HackMD" },
                },
                new SpeakerModel {
                    Id = "PaytonChou",
                    Name = "Payton Chou ",
                    JobTitle = "台灣微軟 微軟技術中心 技術架構師",
                    PictureUrl ="./img/speakers/Payton Chou.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "目前擔任 Microsoft 台灣微軟技術中心技術架構師，負責雲端安全軟體開發流程與敏捷式專案管理，同時也提供雲端架構設計與各種雲端解決方案，憑藉多年的實務經驗，在雲端服務架構及商務應用發展方面，已幫助許多企業實現數位轉型。",
                    Topic = "DevSecOps 最佳實踐與 GitHub Advanced Security on Azure DevOps",
                    TopicOutline = "此議程將探討 DevSecOps 的最佳實踐，我們將介紹在軟體開發流程中整合安全性的關鍵概念，並提供實際案例和建議，以幫助參與者改善他們的軟體開發流程。同時，我們將深入研究 GitHub Advanced Security 在 Azure DevOps 中的應用，認識 Code scanning、Secret scanning、Dependency review 如何幫助我們進一步提升安全性。透過此議程將為開發人員提供實用的介紹，以建立更安全、更高效的開發流程。",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2021, 12, 17, 13, 0, 0),
                    SessionEnd = new DateTime(2021, 12, 17, 17, 30, 0),
                    IsShow = true,
                    Tags = new string[]{ "MS", "HackMD" },
                },
            };

            return speakers;
        }
    }
}
