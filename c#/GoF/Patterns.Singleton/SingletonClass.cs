namespace Patterns.Singleton
{
    public class SingletonClass
    {
        private static SingletonClass _instance;

        private SingletonClass()
        {}

        public static SingletonClass GetInstance()
        {
            _instance = _instance ?? new SingletonClass();
            return _instance;
        }
    }
}
