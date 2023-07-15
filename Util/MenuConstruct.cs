namespace Challenges.Util
{
    public class MenuConstruct
    {
        public void MenuConstruction(string menuName)
        { 
            var countLengthMenuName = menuName.Length;

            var asterisk = string.Empty.PadLeft(countLengthMenuName, '*');
            Console.Clear();

            Console.WriteLine(asterisk);
            Console.WriteLine(menuName);
            Console.WriteLine(asterisk + "\n");
        }
    }
}
