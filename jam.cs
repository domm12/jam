using Terraria.ModLoader; //��, ��� �� ���������� (����������)

namespace jam
{
    class jam : Mod   //�������� ������ ����
    {
        public jam()
        {
            Properties = new ModProperties()
            {
                Autoload = true,           //������������ ����, True - ��
                AutoloadGores = true,      //������������ �������, True - ��
                AutoloadSounds = true      //������������ ������, True - ��
            };
        }
    }
}