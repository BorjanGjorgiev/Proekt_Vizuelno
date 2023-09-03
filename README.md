Опис на апликацијата


Се работи за  играта Кој сака да биде Милионер.


Интерфејс, функционалности


При самото стартување на играта се појавува добро познатиот интерфејс карактеристичен за квизот Кој сака да биде Милионер.Се состои од поле каде што се вчитуваат прашањата и од дополнителни четири копчиња од кои што може да го одбереме соодветниот одговор.Од десната страна најгоре се прикажани трите помошни линии (50:50,Публика,Повикај Пријател).Истите се соодветно имплементирани.Под нив се наоѓа скалата на освоени средства.
Квизот се состои од 15 прашања.
Дополнителни поставени се и аудио елементи од квизот.
Изглед:
![Prva](https://github.com/BorjanGjorgiev/Proekt_Vizuelno/assets/127698412/51ab18a8-ce5d-48bf-ad32-a6c22840f931)


50:50

![Vtora](https://github.com/BorjanGjorgiev/Proekt_Vizuelno/assets/127698412/1c19701c-f4c9-4d33-be14-3db3452746e7)


Публика

![Treta](https://github.com/BorjanGjorgiev/Proekt_Vizuelno/assets/127698412/b4be7587-7f78-4a0f-aa39-4042c02e0751)


Повикај Пријател

![Cetvrta](https://github.com/BorjanGjorgiev/Proekt_Vizuelno/assets/127698412/a4ffdb2f-00d4-466b-86e8-271c56206da7)


Програмско решение:
Промената на прашањата e организирано преку switch-case методата.
За користењето на помошните линии ја употребив податочната структура Dictionary која што беше организирана на следниот начин.Клучот претставуваше број на прашањето а вредност беше точниот одговор(од 1 до 4). 
    private void pictureBox3_Click(object sender, EventArgs e)
    {
        panel17.Show();
        timer1.Start();





        Random random = new Random();


        int TocenOdgovor = random.Next(50, 101);
        Dictionary<int, int> tabela = new Dictionary<int, int>
        {
{ 1, 3 },
{ 2, 2 },
{ 3, 1 },
{ 4, 3 },
{ 5, 4 },
{ 6, 2 },
{ 7, 1 },
{ 8, 1 },
 { 9, 4 },
{ 10, 2 },
{ 11, 3 },
{ 12, 1 },
{ 13, 1 },
{ 14, 2 },
{ 15, 3 }
        };

        int searchKey = (int)Convert.ToUInt32(label13.Text);

        if (tabela.ContainsKey(searchKey))
        {
            int correctOption = tabela[searchKey];
            if (correctOption == 1)
            {
                int opcija3 = random.Next(0, 50);
                int opcija2 = random.Next(0, 50);
                int opcija4 = random.Next(0, 50);
                progressBar1.Value = TocenOdgovor;
                NumA.Text = TocenOdgovor.ToString();
                NumB.Text = opcija2.ToString();
                NumC.Text = opcija3.ToString();
                NumD.Text = opcija4.ToString();
                progressBar2.Value = opcija2;
                progressBar3.Value = opcija3;
                progressBar4.Value = opcija4;

            }
За помошната линија 50:50 ја искористив Random класата која што изгенерира два случајни броја кои што треба да се избришат од понудените одговори.Во овој случај битно е да го зачуваме точниот одговор.Истотака класата Random ја искористив кај Progressbar со цел вредноста на прогрес барот да се пополни соодветно.Дополнително искористена е и класата SoundPlayer за да се внесат аудио елементи во квизот.


         SoundPlayer Muzika = new SoundPlayer(@"C:\\Users\\user\\Desktop\\Proekt_VP\\Proekt_VP\\Resources\Who Wants To Be A Millionaire Full Theme.wav");

        SoundPlayer Muzika2 = new SoundPlayer(@"C:\Users\user\Desktop\Proekt_VP\Proekt_VP\\Resources\Pokratko.wav");

При неточен одговор на било кое прашање се враќаме на самиот почеток.
Изработил:
Борјан Ѓоргиев 213184.
