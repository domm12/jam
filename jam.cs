using Terraria.ModLoader; //То, что мы используем (Библиотеки)

namespace jam
{
    class jam : Mod   //Создание класса мода
    {
        public jam()
        {
            Properties = new ModProperties()
            {
                Autoload = true,           //Автозагрузка мода, True - Да
                AutoloadGores = true,      //Автозагрузка Эфектов, True - Да
                AutoloadSounds = true      //Автозагрузка Звуков, True - Да
            };
        }
    }
}