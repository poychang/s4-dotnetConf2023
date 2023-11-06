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
                    Name = "Will 保哥",
                    JobTitle = "多奇數位創意 技術總監",
                    PictureUrl ="./img/speakers/Will 保哥.jpg",
                    BlogUrl = "http://blog.miniasp.com/",
                    FacebookUrl = "https://www.facebook.com/will.fans/",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "現任「多奇數位創意有限公司」技術總監。2018 年榮獲 Angular 方向的 Google Developer Expert (GDE) 開發專家。連續 14 度當選微軟最有價值專家(MVP)。2019 獲選微軟技術社群區域總監 (Microsoft Regional Director)。熟悉 Angular、JavaScript、.NET、C#、ASP.NET MVC、Go、Docker、Kubernetes 相關技術。擅長 DevOps 與組織文化建立、軟體團隊建構與管理。熱愛分享知識。",
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
                    PictureUrl ="./img/speakers/Bruce Chen-2.jpg",
                    BlogUrl = "https://blog.kkbruce.net/",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "任職於全美前 50 大私人企業。SkillTree.my、微軟 TechDays、MSDN 講座、Azure Bootcamp 講師，於 ASP.NET MVC 2.0 接觸 MVC 架構，從此愛上 MVC 推廣 MVC，對於 ASP.NET Web API 框架也有深入研究，是宣導 ASP.NET Web API 的先驅。2013 年先後加入 STUDY4 與 twMVC 社群核心講師，不定期分享開發技術與經驗。出版作品有《ASP.NET MVC4 網站開發美學》、《ASP.NET MVC 5網站開發美學》、《ASP.NET MVC 5 网站开发之美》。對於開發人員最頭疼的前端 Layout 問題，翻譯《Bootstrap 2》《Bootstrap 3》繁體中文文件更是學習 Bootstrap 的必讀資料。",
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
                    Id = "Kevin Yang",
                    Name = "Kevin Yang",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/Kevin Yang.jpg",
                    BlogUrl = "https://blog.kevinyang.net/",
                    FacebookUrl = "https://www.facebook.com/CKNotepad/",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "目前擔任 Angular Taiwan、Angular Girls Taiwan 、TypeScript Taiwan 社群管理者，Angular 線上讀書會主持人。2018 年榮獲 Angular/Web GDE (Google Developer Expert) 開發專家。微軟最有價值專家 (Visual Studio and Development Technologies)。熱衷分享任何新奇的技術資訊、不務正業(跨領域)，目前已跨入的領域有會計、醫療資訊及程式開發。",
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
                    Id = "Jimmy Ho",
                    Name = "Jimmy Ho",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/Jimmy Ho.jpg",
                    BlogUrl = "https://jiaming0708.github.io/",
                    FacebookUrl = "https://www.facebook.com/secretgogoworld",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "一個熱愛學習、分享並且近期狂點前端技能樹的小小工程師，什麼都會什麼都不奇怪。",
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
                    Introduction = "講師於 2014 年投入遊戲業，2018 年起在一家 AR/VR/XR 相關遊戲、商務應用開發的新創公司擔任 CTO；Xamarin, ASP.NET Core 等前後端開發技術都略懂略懂，但抓 bug 比較在行。",
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
                    Id = "Alan Tsai",
                    Name = "Alan Tsai",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/Alan Tsai.jpg",
                    BlogUrl = "https://blog.alantsai.net/",
                    FacebookUrl = "http://fb.alantsai.net/",
                    TwitterUrl = "http://twitter.alantsai.net/",
                    LinkedinUrl = "http://linkedin.alantsai.net/",
                    YouTubeUrl = "http://yt.alantsai.net/",
                    Introduction = "深耕 .NET 軟體開發多年，深信使用的技術不是重點，重點在於如何全面的思考並且用適合的技術解決客戶的問題，為現任的微軟最有價值專家（Microsoft MVP）- Azure，微軟認證講師（MCT），樂於分享，深信教就是最好的學習方式，定期發佈部落格（Alan Tsai 的學習筆記）文章、影片、演講分享或者幫忙翻譯。很宅，除了上班之外會出去應該都是參加/協助社群活動（Azure Taiwan），為現任 Study4.TW 成員之一。除了程式以外，就愛看小說。",
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
                    Id = "Marcus",
                    Name = "Marcus Tung",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/Marcus Tung.jpg",
                    BlogUrl = "https://marcus116.blogspot.com/",
                    FacebookUrl = "https://www.facebook.com/marcus.tung.3",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "後端打雜小弟，10 年以上軟體相關開發經驗，喜歡上技術相關課程、參與外部研討會吸收新知識。",
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
                    Id = "Mike",
                    Name = "黃升煌 Mike",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/Mike.jpg",
                    BlogUrl = "https://wellwind.idv.tw/blog/",
                    FacebookUrl = "https://www.facebook.com/fullstackledder",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "目前是 Microsoft MVP 及 Angular，熟悉 .NET WebAPI 與 Angular 開發技術，主要於個人部落格分享學習知識，並活躍於 Angular Taiwan Facebook 社團。",
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
                    TopicOutline = "生成式 AI 應用的誘發劑是 Prompt，因此提示工程（Prompt Engineering）成為炙手可熱的議題，然而從開發層面來看，實作一個真實場景的生成式應用，<br/>除了 Prompt 之外往往會遇面臨到如何處理上下文記憶、Few-Shot、Embeddings、Plugins 等機制的整合，當然神人可以全面自已來實現，而凡人的你我不<br/>用現成解決方案就太對不起自已啦。<br/>Semantic Kernel 是 Microsoft 在打造 GitHub Copilot、M365 Copilot、Bing Chat 所用的核心，現已開源是一個輕量化的 SDK 且即將正式迎來 1.0 版本，<br/>它支援 C#、Python、Java、TypeScriopt 程式語言，將開發生成式 AI 應用以 Pipeline 概念展開，提供一個生成式 AI 應用開發 Pattern。<br/>本場次除了帶大家來認識 Semantic Kernel 之外，我也將示範如何使用 Semantic Kernel，融合 GPT 模型，透過 Prompt 及 Plugin，打造生成式 AI 應用。",
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
                    Id = "Summit",
                    Name = "Summit",
                    JobTitle = "TBD",
                    PictureUrl ="./img/speakers/孫玉峰.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "TBD",
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
                    Id = "JamesTsai",
                    Name = "James Tsai",
                    JobTitle = "TBD",
                    PictureUrl ="./img/speakers/James Tsai.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "TBD",
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
                    JobTitle = "",
                    PictureUrl ="./img/speakers/Weithenn.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "超過十年榮獲 Microsoft MVP 和 VMware vExpert，並長期擔任網管人雜誌技術專欄作家，曾擔任 Kubernetes Summit 2022、DevOpsDays Taipei 2022、Cloud Edge Summit Taiwan 2022、SRE Conference 2022、DevOpsDays Taipei 2021、Cloud & Edge Summit Taiwan 2021……等研討會講師，專長為打造 SDDC 軟體定義資料中心、HCI 超融合解決方案、IaC 基礎架構即程式碼環境……等，著有微軟 S2D 軟體定義儲存技術實戰……等共 19 本著作。",
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
                    Id = "JiaSin",
                    Name = "陳佳新",
                    JobTitle = "",
                    PictureUrl ="./img/speakers/陳佳新.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "TBD",
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
                    Id = "hwchiu",
                    Name = "邱宏瑋",
                    JobTitle = "",
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
                    JobTitle = "",
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
                    Id = "RyanChung",
                    Name = "Ryan Chung",
                    JobTitle = "微軟最有價值專家",
                    PictureUrl ="./img/speakers/Ryan Chung.jpg",
                    BlogUrl = "",
                    FacebookUrl = "",
                    TwitterUrl = "",
                    LinkedinUrl = "",
                    Introduction = "Ryan Chung，行動開發學院創辦人，曾獲微軟人工智能大賽特別獎、Udacity AI 產品經理微學位。目前為美國 Pluralsight 認證講師、中央大學 AI 學程兼任講師、元智大學資工系兼任助理教授級專業技術人員。專長於 Web/App 應用開發、企業 AI 加值導入、微軟 OpenAI 與認知服務應用整合。2022 年起，獲選為微軟 MVP - AI 人工智慧最有價值專家。共同著作：駕馭 ChatGPT 4: 探索 Azure OpenAI 與 Cognitive Service for Language 開發實踐（使用 .NET 與 Node.js）。",
                    Topic = "TBD",
                    TopicOutline = "TBD",
                    Room = "",
                    Track = "",
                    SessionStart = new DateTime(2023, 12, 9, 0, 0, 0),
                    SessionEnd = new DateTime(2023, 12, 10, 0, 0, 0),
                    IsShow = true,
                    Tags = new string[]{ "CM", "HackMD" },
                },new SpeakerModel {
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
            };

            return speakers;
        }
    }
}
