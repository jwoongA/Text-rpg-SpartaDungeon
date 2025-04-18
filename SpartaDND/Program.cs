using System;
using System.ComponentModel.Design;

namespace SpartaDND
{
    internal class Program
    {

        static string SetPlayerName()
        {
            string playerName = "";
            bool nameConfirmed = false;

            while (!nameConfirmed) // 사용자 이름을 입력하고 확정할 때까지 반복하는 루프
            {
                Console.Clear();
                Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
                Console.WriteLine("원하시는 이름을 설정해주세요.");
                Console.WriteLine();
                Console.Write(">>");
                playerName = Console.ReadLine()!;

                bool validChoice = false;

                while (!validChoice) // 입력한 이름이 유효한지 확인하고, 유효하지 않다면 재입력을 요청하는 루프
                {
                    Console.Clear();
                    Console.WriteLine($"입력하신 이름은 '{playerName}' 입니다.");
                    Console.WriteLine();
                    Console.WriteLine("1. 맞다");
                    Console.WriteLine("2. 아니다");
                    Console.WriteLine();
                    Console.WriteLine("원하시는 행동을 입력해주세요.");
                    Console.Write(">>");
                    string choice = Console.ReadLine()!;

                    if (choice == "1")
                    {
                        nameConfirmed = true; // 바깥쪽 루프 종료
                        validChoice = true; // 안쪽 루프 종료
                        Console.WriteLine();
                        Console.WriteLine($"'{playerName}'님, 환영합니다.");
                        Console.WriteLine();
                        Console.WriteLine("계속하려면 아무 키나 누르세요...");
                        Console.ReadKey();
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("다시 이름을 설정합니다...");
                        Thread.Sleep(1000);
                        validChoice = true; // 안쪽 루프 종료 -> 바깥쪽 루프부터 다시 시작
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        Thread.Sleep(1000); // 안쪽 루프 계속 반복
                    }
                }
            }

            Console.Clear();
            return playerName;
        }

        static string ChooseJob(string playerName)
        {
            string playerJob = "";
            bool jobValid = false;

            while (!jobValid) // 바깥쪽 루프
            {
                Console.Clear();
                Console.WriteLine($"{playerName}님 당신의 직업을 선택해주세요.");
                Console.WriteLine();
                Console.WriteLine("1. 전사");
                Console.WriteLine("2. 도적");
                Console.WriteLine();
                Console.WriteLine("원하시는 직업을 선택해주세요.");
                Console.Write(">>");
                string jobChoice = Console.ReadLine()!;

                switch (jobChoice)
                {
                    case "1":
                        playerJob = "전사";
                        break;
                    case "2":
                        playerJob = "도적";
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        Thread.Sleep(1000);
                        continue;
                }

                bool confirmValid = false;
                while (!confirmValid) // 안쪽 루프
                {
                    Console.Clear();
                    switch (playerJob)
                    {
                        case "전사":
                            Console.WriteLine("전사는 높은 체력과 힘을 기반으로 싸우는 직업입니다.");
                            Console.WriteLine("다른 직업에 비해 민첩과 지능이 낮습니다.");
                            break;
                        case "도적":
                            Console.WriteLine("도적은 높은 민첩과 힘을 기반으로 싸우는 직업입니다.");
                            Console.WriteLine("다른 직업에 비해 체력과 방어력이 낮습니다.");
                            break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("당신의 운명을 선택하시겠습니까?");
                    Console.WriteLine("1. 선택");
                    Console.WriteLine("2. 취소");
                    Console.WriteLine();
                    Console.Write(">>");
                    string confirm = Console.ReadLine()!;

                    if (confirm == "1")
                    {
                        jobValid = true; // 바깥쪽 루프 종료
                        confirmValid = true; // 안쪽 루프 종료
                    }
                    else if (confirm == "2")
                    {
                        Console.WriteLine("직업을 다시 선택합니다...");
                        Thread.Sleep(1000);
                        confirmValid = true; // 안쪽 루프만 종료, 바깥쪽 루프 다시 시작
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        Thread.Sleep(1000);
                        // 루프 종료 없음 안쪽 루프 다시시작
                    }
                }
            }

            Console.Clear();
            return playerJob;
        }

        static void PlayJobIntro(string playerJob)
        {
            Console.Clear();

            switch (playerJob)
            {
                case "전사":
                    Console.WriteLine("당신이 전사가 되기로 결심하자... ");
                    Console.WriteLine("마치 환상처럼, 현실과 동떨어진 감각이 당신을 덮쳐옵니다.");
                    Thread.Sleep(1000);

                    Console.WriteLine();
                    Console.WriteLine("어디선가 들려오는 북소리.");
                    Console.WriteLine("함성, 뿔피리, 검이 부딪히는 날카로운 쇳소리.");
                    Console.WriteLine("그것들은 실제가 아니었습니다.");
                    Console.WriteLine("하지만 너무도 생생해서, 당신의 심장은 반응했습니다.");
                    Thread.Sleep(1000);

                    Console.WriteLine();
                    Console.WriteLine("숨소리는 거칠어지고, 손끝엔 묵직한 검의 감촉이 남아 있습니다.");
                    Console.WriteLine("그 순간, 당신은 분명히 느꼈습니다.");
                    Console.WriteLine("아직 전장을 밟아보지도 않았지만—");
                    Console.WriteLine("당신의 몸 어딘가에는 이미 '전사'의 피가 흐르고 있었습니다.");
                    Thread.Sleep(1000);

                    Console.WriteLine();
                    Console.WriteLine("소리는 잦아들고, 시야는 다시 현실로 돌아옵니다.");
                    Console.WriteLine("당신은 조용히 검 손잡이를 쥐고, 그저 앞으로 나아갈 준비를 합니다.");
                    Thread.Sleep(1000);

                    Console.WriteLine();
                    Console.WriteLine("전투는 아직 시작되지 않았지만,");
                    Console.WriteLine("당신의 의지는 그보다 앞서 전사로 태어났습니다.");
                    break;

                case "도적":
                    Console.WriteLine("당신이 도적이 되기로 결심한 순간,");
                    Console.WriteLine("주변은 마치 안개처럼 조용히, 그러나 낯설게 뒤틀리기 시작합니다.");
                    Thread.Sleep(1000);

                    Console.WriteLine();
                    Console.WriteLine("천천히 고개를 돌리자, 익숙하지 않은 골목 어귀가 시야에 들어옵니다.");
                    Console.WriteLine("피비린내, 스치는 발소리, 날카로운 숨소리.");
                    Console.WriteLine("누군가 당신을 감시하고 있는 것 같지만, 이상하게도 두렵지 않습니다.");
                    Console.WriteLine("오히려 그 모든 긴장감이, 신경을 더욱 곤두서게 만듭니다.");
                    Thread.Sleep(1000);

                    Console.WriteLine();
                    Console.WriteLine("손끝에 차가운 단검의 감촉이 전해집니다.");
                    Console.WriteLine("그립감은 낯설지 않았고,");
                    Console.WriteLine("몸은 스스로, 마치 오래전부터 익혀온 듯 움직이기 시작합니다.");
                    Thread.Sleep(1000);

                    Console.WriteLine();
                    Console.WriteLine("발소리를 죽이고, 벽에 등을 붙이고,");
                    Console.WriteLine("그림자 속에 스며들어 사라질 준비를 합니다.");
                    Console.WriteLine("누군가 다가옵니다.");
                    Console.WriteLine("하지만 당신은 이미 예상했고, 움직일 타이밍마저 본능처럼 알고 있습니다.");
                    Thread.Sleep(1000);

                    Console.WriteLine();
                    Console.WriteLine("그리고—");
                    Console.WriteLine("모든 소리가 멎습니다.");
                    Thread.Sleep(1000);

                    Console.WriteLine();
                    Console.WriteLine("짧은 숨, 얕은 발걸음, 귓가에 맴도는 심장 소리.");
                    Console.WriteLine("환상은 이내 사라지고, 당신은 다시 현실로 돌아옵니다.");
                    Console.WriteLine("그러나 그 순간의 감각은 선명하게 남아 있습니다.");
                    Thread.Sleep(1000);

                    Console.WriteLine();
                    Console.WriteLine("기억도, 기술도 없지만…");
                    Console.WriteLine("당신은 분명 도적입니다.");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("계속하려면 아무 키나 누르세요...");
            Console.ReadKey();
            Console.Clear();
        }

        class Charactor
        {
            public string Name { get; set; }
            public string Job { get; set; }
            public int Level { get; set; } = 1;
            public int Attack { get; set; }
            public int Defense { get; set; }
            public int MaxHP { get; set; }
            public int HP { get; set; }
            public int Gold { get; set; }
            public List<string> Inventory { get; private set; } = new List<string>();



            public Charactor(string name, string job)
            {
                Name = name;
                Job = job;
                Gold = 1500;
                Inventory = new List<string>();

                if (Job == "전사")
                {
                    Attack = 10;
                    Defense = 5;
                    MaxHP = 100;
                    HP = MaxHP;
                }
                else if (Job == "도적")
                {
                    Attack = 12;
                    Defense = 4;
                    MaxHP = 80;
                    HP = MaxHP;
                }
            }

            public int GetTotalStat(string statType)
            {
                int bonus = 0;

                foreach (var item in Inventory)
                {
                    if (item.StartsWith("[E]") && item.Contains(statType)) // 아이템에 [E] 표시가 있고 statType이 포함된 경우
                    {
                        bonus += ParseStatValue(item, statType);
                    }
                }

                if (statType == "공격력") // statType이 공격력인 겨우
                {
                    return Attack + bonus;
                }

                if (statType == "방어력") // statType이 방어력인 경우
                {
                    return Defense + bonus;
                }

                return bonus;
            }

            private int ParseStatValue(string item, string statType)
            {
                string[] parts = item.Split('|');
                if (parts.Length < 2)
                {
                    return 0;
                }

                string statText = parts[1];
                if (statText.Contains(statType))
                {
                    int plusIndex = statText.IndexOf("+");
                    if (plusIndex >= 0 && int.TryParse(statText.Substring(plusIndex + 1), out int value)) // + 기호 이후의 숫자를 정수로 변환시켜 value값에 저장
                    {
                        return value;
                    }
                }
                return 0;
            }

            public void ShowStatus()
            {
                bool outBtn = false;

                while (!outBtn)
                {
                    Console.Clear();
                    Console.WriteLine("[상태창]");
                    Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                    Console.WriteLine();
                    Console.WriteLine($"Lv. {Level:D2}");
                    Console.WriteLine($"{Name} ( {Job} )");

                    int atkBonus = GetTotalStat("공격력") - Attack;
                    int defBonus = GetTotalStat("방어력") - Defense;

                    if (atkBonus > 0)
                    {
                        Console.WriteLine($"공격력 : {Attack} (+{atkBonus})");
                    }
                    else
                    {
                        Console.WriteLine($"공격력 : {Attack}");
                    }

                    if (defBonus > 0)
                    {
                        Console.WriteLine($"방어력 : {Defense} (+{defBonus})");
                    }
                    else
                    {
                        Console.WriteLine($"방어력 : {Defense}");
                    }

                    Console.WriteLine($"체 력 : {HP}");
                    Console.WriteLine($"Gold : {Gold} G");
                    Console.WriteLine();
                    Console.WriteLine("0. 나가기");
                    Console.WriteLine();
                    Console.WriteLine("원하시는 행동을 입력해주세요.");
                    Console.Write(">>");
                    string statInput = Console.ReadLine()!;

                    if (statInput == "0")
                    {
                        outBtn = true;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
            }

            public void ShowInventory()
            {
                bool outBtn = false;
                while (!outBtn) // 바깥쪽 루프
                {
                    PrintInventory();

                    bool inputConfirmed = false;
                    while (!inputConfirmed) // 안쪽 루프
                    {
                        Console.Write(">>");
                        string input = Console.ReadLine()!;

                        if (input == "1")
                        {
                            ManageEquipment();
                            Thread.Sleep(1000);
                            inputConfirmed = true; // 안쪽 루프 종료

                        }
                        else if (input == "2")
                        {
                            outBtn = true; // 바깥쪽 루프 종료
                            inputConfirmed = true; // 안쪽 루프 종료
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                            Thread.Sleep(1000);
                            PrintInventory();
                        }
                    }
                }
            }

            private void PrintInventory()
            {
                Console.Clear();
                Console.WriteLine("[인벤토리]");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");

                if (Inventory.Count == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    foreach (var item in Inventory)
                    {
                        string[] parts = item.Split('|');
                        string name;
                        if (parts.Length > 0)
                        {
                            name = parts[0];
                        }
                        else
                        {
                            name = "";
                        }
                        string stat;
                        if (parts.Length > 1)
                        {
                            stat = parts[1];
                        }
                        else
                        {
                            stat = "";
                        }
                        string desc;
                        if (parts.Length > 2)
                        {
                            desc = parts[2];
                        }
                        else
                        {
                            desc = "";
                        }
                        Console.WriteLine($"{name,-3} | {stat,-3} | {desc}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("1. 장착 관리");
                Console.WriteLine("2. 나가기");
            }

            private void ManageEquipment()
            {
                bool back = false;
                while (!back)
                {
                    Console.Clear();
                    Console.WriteLine("[인벤토리] - 장착 관리");
                    Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                    Console.WriteLine();
                    Console.WriteLine("[아이템 목록]");

                    if (Inventory.Count == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("장착할 수 있는 아이템이 없습니다.");
                    }
                    else
                    {
                        for (int i = 0; i < Inventory.Count; i++)
                        {
                            string[] parts = Inventory[i].Split('|');
                            string name;
                            if (parts.Length > 0)
                            {
                                name = parts[0];
                            }
                            else
                            {
                                name = "";
                            }

                            string stat = parts[1];
                            if (parts.Length > 1)
                            {
                                stat = parts[1];
                            }
                            else
                            {
                                stat = "";
                            }

                            string desc;
                            if (parts.Length > 2)
                            {
                                desc = parts[2];
                            }
                            else
                            {
                                desc = "";
                            }

                            string equippedMark = $"-{i + 1}";
                            if (name.StartsWith("[E]"))
                            {
                                name = name.Replace("[E]", "").Trim();
                                name = "[E]" + name;
                            }

                            Console.WriteLine($"{equippedMark} {name,-3} | {stat,-3} | {desc}");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("0. 나가기");
                    Console.WriteLine();
                    Console.WriteLine("원하시는 행동을 입력해주세요.");
                    Console.Write(">>");
                    string input = Console.ReadLine()!;

                    if (input == "0")
                    {
                        back = true;
                    }
                    else
                    {
                        bool isValidNumber = int.TryParse(input, out int selectedIndex);
                        selectedIndex -= 1;

                        if (!isValidNumber)
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                        else if (selectedIndex < 0 || selectedIndex >= Inventory.Count)
                        {
                            Console.WriteLine("해당 번호의 아이템이 없습니다.");
                        }
                        else
                        {
                            string item = Inventory[selectedIndex];
                            bool isEquipped = item.StartsWith("[E]");

                            item = item.Replace("[E]", "").Trim();

                            if (isEquipped)
                            {
                                //장착된 상태라면 해제
                                Inventory[selectedIndex] = item;
                            }
                            else
                            {
                                //장착되지 않은 상태라면 장착
                                Inventory[selectedIndex] = "[E]" + item;
                            }
                        }

                        Thread.Sleep(1000);
                    }

                }
            }
        }

        static void ShowMainMenu(Charactor player)
        {
            bool stayInMenu = true;

            while (stayInMenu)
            {
                Console.Clear();
                Console.WriteLine($"스파르타 마을에 오신 {player.Name}님 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 상태보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("4. 던전입장");
                Console.WriteLine("5. 휴식하기");
                Console.WriteLine("0. 게임 종료");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">>");
                string input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        player.ShowStatus();
                        break;
                    case "2":
                        player.ShowInventory();
                        break;
                    case "3":
                        ShopMenu(player);
                        break;
                    case "4":
                        DungeonMenu(player);
                        break;
                    case "5":
                        Rest(player);
                        break;
                    case "0":
                        Console.WriteLine("게임을 종료합니다.");
                        stayInMenu = false;
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        Thread.Sleep(1000);
                        continue;
                }

                if (stayInMenu)
                {
                    Console.WriteLine("계속하려면 아무 키나 누르세요...");
                    Console.ReadKey();
                }
            }
        }

        static List<string> shopItems = new()
        {
            "수련자 갑옷 | 방어력 +5 | 수련에 도움을 주는 갑옷입니다. | 1000",
            "무쇠갑옷 | 방어력 +9 | 무쇠로 만들어져 튼튼한 갑옷입니다. | 2000 G",
            "스파르타 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | 3500",
            "낡은 검 | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다. | 500",
            "청동 도끼 | 공격력 +5 | 어디선가 사용됐던거 같은 도끼입니다. | 1500",
            "스파르타 창 | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다. | 3000"
        };

        static List<int> purschasedItem = new();

        static void ShopMenu(Charactor player)
        {
            bool stayInShop = true;

            while (stayInShop)
            {
                Console.Clear();
                Console.WriteLine("[상점]");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine();
                Console.WriteLine("[보유 골드]");
                Console.WriteLine($"{player.Gold} G");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");

                for (int i = 0; i < shopItems.Count; i++)
                {
                    string[] parts = shopItems[i].Split('|');
                    if (purschasedItem.Contains(i))
                    {
                        Console.WriteLine($"- {parts[0]} | {parts[1]} | {parts[2]} | [구매 완료]");
                    }
                    else
                    {
                        Console.WriteLine($"- {parts[0]} | {parts[1]} | {parts[2]} | {parts[3]} G");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">>");
                string shopInPut = Console.ReadLine()!;


                if (shopInPut == "1")
                {
                    BuyItem(player);
                }
                else if (shopInPut == "0")
                {
                    Console.WriteLine();
                    Console.WriteLine("상점을 나갑니다.");
                    stayInShop = false;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                }
            }
        }

        static void BuyItem(Charactor player)
        {
            Console.Clear();
            Console.WriteLine("[상점]");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");

            for (int i = 0; i < shopItems.Count; i++)
            {
                string[] parts = shopItems[i].Split('|');
                if (purschasedItem.Contains(i))
                {
                    Console.WriteLine($"- {i + 1} {parts[0]} | {parts[1]} | {parts[2]} | [구매 완료]");
                }
                else
                {
                    Console.WriteLine($"- {i + 1} {parts[0]} | {parts[1]} | {parts[2]} | {parts[3]} G");
                }
            }

            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");
            string buyInput = Console.ReadLine()!;

            if (buyInput == "0")
            {
                return;
            }

            if (int.TryParse(buyInput, out int index) && index >= 1 && index <= shopItems.Count)
            {
                index -= 1; // 리스트 인덱스는 0부터 시작하므로 조정
                if (purschasedItem.Contains(index))
                {
                    Console.WriteLine("이미 구매한 아이템입니다. 다른 아이템을 선택해주세요.");
                }
                else
                {
                    string[] parts = shopItems[index].Split('|');
                    string name = parts[0];
                    string stat = parts[1];
                    string desc = parts[2];
                    int price = int.Parse(parts[3]);

                    if (player.Gold >= price)
                    {
                        player.Gold -= price;
                        player.Inventory.Add($"{name,-3} | {stat,-3} | {desc,-3}");
                        purschasedItem.Add(index);
                        Console.WriteLine($"{name}을(를) 구매하였습니다!");
                    }
                    else
                    {
                        Console.WriteLine("Gold가 부족합니다.");
                    }
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
            Console.WriteLine("계속하려면 아무 키나 눌러주세요...");
            Console.ReadKey();
        }

        static void DungeonMenu(Charactor player)
        {
            bool stayInDungeon = true;

            while (stayInDungeon)
            {
                Console.Clear();
                Console.WriteLine("[던전]");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 쉬운 던전   | 방어력 5 이상 권장");
                Console.WriteLine("2. 일반 던전   | 방어력 11 이상 권장");
                Console.WriteLine("3. 어려운 던전 | 방어력 17 이상 권장");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">>");
                string input = Console.ReadLine()!;

                bool isValidNumber = false;

                while (!isValidNumber)
                {
                    if (input == "1")
                    {
                        EasyDungeon(player);
                        isValidNumber = true;
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("아직 구현중...");
                        Console.ReadKey();
                        isValidNumber = true;
                    }
                    else if (input == "3")
                    {
                        Console.WriteLine("아직 구현중...");
                        Console.ReadKey();
                        isValidNumber = true;
                    }
                    else if (input == "0")
                    {
                        stayInDungeon = false;
                        isValidNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        Thread.Sleep(1000);
                        isValidNumber = true;
                    }
                }
            }
        }

        static void EasyDungeon(Charactor player)
        {
            int requiredDefense = 5;
            int playerDefense = player.GetTotalStat("방어력");

            Console.Clear();
            Console.WriteLine("[쉬운 던전]");
            Console.WriteLine();
            Thread.Sleep(1000);

            if (playerDefense >= requiredDefense)
            {
                Console.WriteLine("던전에 입장합니다...");
                Thread.Sleep(1000);

                int baseMin = 20;
                int baseMax = 35;
                int defenseOffset = requiredDefense - playerDefense;

                int rawDamage = new Random().Next(baseMin, baseMax + 1);
                int finalDamage = rawDamage + defenseOffset;

                if (finalDamage < 0)
                {
                    finalDamage = 0;
                }

                player.HP -= finalDamage;

                if (player.HP < 0)
                {
                    player.HP = 0;
                }

                Console.WriteLine();
                Console.WriteLine($"{player.Name}님은 던전을 클리어 했습니다!");
                Console.WriteLine($"{finalDamage}의 피해를 입었습니다.");
                EasyDungeonReward(player);
                Console.WriteLine();
                Console.WriteLine($"남은 체력 : {player.HP}");
                Console.WriteLine();
                Console.WriteLine("계속하려면 아무 키나 누르세요...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("던전에 입장합니다...");
                Thread.Sleep(1000);

                Random random = new Random();
                int chance = random.Next(1, 101);

                if (chance < 40)
                {
                    Console.WriteLine();
                    Console.WriteLine("던전탐험 중 적을 만나 심각한 부상을 입었습니다.");
                    Console.WriteLine("부상당한 몸을 이끌고 던전을 탈출합니다.");
                    player.HP /= 2;

                    if (player.HP < 0)
                    {
                        player.HP = 0;
                    }

                    Console.WriteLine();
                    Console.WriteLine("체력이 절반으로 감소되었습니다.");
                    Console.WriteLine($"현재 체력 : {player.HP}");
                    Console.WriteLine();
                    Console.WriteLine("계속하려면 아무 키나 누르세요...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("던전에 입장합니다...");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("던전탐사에 애를 먹었지만 보상은 찾을 수 있었습니다.");
                    Console.WriteLine();

                    int baseMin = 20;
                    int baseMax = 35;
                    int defenseOffset = requiredDefense - playerDefense;

                    int rawDamage = new Random().Next(baseMin, baseMax + 1);
                    int finalDamage = rawDamage + defenseOffset;

                    if (finalDamage < 0)
                    {
                        finalDamage = 0;
                    }

                    player.HP -= finalDamage;

                    if (player.HP < 0)
                    {
                        player.HP = 0;
                    }

                    Console.WriteLine($"{player.Name}님은 던전을 클리어 했습니다!");
                    Console.WriteLine($"{finalDamage}의 피해를 입었습니다.");
                    EasyDungeonReward(player);
                    Console.WriteLine();
                    Console.WriteLine($"남은 체력 : {player.HP}");
                    Console.WriteLine();
                    Console.WriteLine("계속하려면 아무 키나 누르세요...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void EasyDungeonReward(Charactor player)
        {
            int baseReward = 1000;
            int atk = player.GetTotalStat("공격력");
            int bonus = atk * new Random().Next(8, 13);

            int totalReward = baseReward + bonus;
            player.Gold += totalReward;

            Console.WriteLine($"던전에서 보상으로 {totalReward} G를 얻었습니다!");
        }

        static void Rest(Charactor player)
        {
            bool restConfirmed = false;
            while (!restConfirmed)
            {
                Console.Clear();
                Console.WriteLine("[휴식하기]");
                Console.WriteLine("500 G 를 내면 여관에서 체력을 회복할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine($"현재 체력 : {player.HP}");
                Console.WriteLine($"보유 골드 : {player.Gold} G");
                Console.WriteLine();
                Console.WriteLine("1. 휴식하기");
                Console.WriteLine("2. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">>");
                string input = Console.ReadLine()!;

                bool restLoop = false;
                while (!restLoop)
                {
                    if (input == "1")
                    {
                        if (player.Gold >= 500)
                        {
                            player.Gold -= 500;
                            if (player.HP + 100 > player.MaxHP)
                            {
                                player.HP = player.MaxHP;
                            }
                            else
                            {
                                player.HP += 100;
                            }
                            Console.WriteLine();
                            Console.WriteLine("체력이 회복되었습니다.");
                            Thread.Sleep(1000);
                            restLoop = true;
                        }
                        else
                        {
                            Console.WriteLine("Gold가 부족합니다.");
                            Thread.Sleep(1000);
                            restLoop = true;
                        }
                    }
                    else if (input == "2")
                    {
                        restConfirmed = true;
                        restLoop = true;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        Thread.Sleep(1000);
                        restLoop = true;
                    }
                }
            }
        }

        static void Main()
        {
            string playerName = SetPlayerName();
            string playerJob = ChooseJob(playerName);
            PlayJobIntro(playerJob);
            Charactor player = new(playerName, playerJob);

            Console.WriteLine($"긴 여정 끝에, {playerName}님은 소문을 쫒아 던전에 가까운 마을에 도착했습니다.");
            Thread.Sleep(1500);

            Console.WriteLine("이곳에서 당신의 모험이 시작됩니다.");
            Console.WriteLine();
            Console.WriteLine("계속하려면 아무 키나 누르세요...");
            Console.ReadKey();
            Console.Clear();

            ShowMainMenu(player);
        }
    }
}