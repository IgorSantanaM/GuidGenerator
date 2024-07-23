namespace GuidGenerator
{
    public static class Generator
    {
        public static void GuidGenerate(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Guid guid = Guid.NewGuid();
                Console.WriteLine(guid);
            }
        }
    }
}
