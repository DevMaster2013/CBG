using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core
{
    public static class GameTime
    {
        private static double _currentTime = 0.0;
        private static double _currentGameTime = 0.0;
        private static double _gameTimeScale = 1.0;
        private static double _elapsedTime = 0.0;

        public static void updateTime(double elapsedSeconds)
        {
            _elapsedTime = elapsedSeconds;
            _currentTime += elapsedSeconds;
            _currentGameTime += elapsedSeconds * _gameTimeScale;
        }

        public static double ElapsedTime { get { return _elapsedTime; } }
        public static double CurrentTime { get { return _currentTime; } }        
        public static double GameTimeScale { get { return _gameTimeScale; } set { _gameTimeScale = value; } }
        public static double Seconds { get { return _elapsedTime; } }
        public static double Minutes { get { return _elapsedTime / 60.0; } }
        public static double Hours { get { return _elapsedTime / (60.0 * 60.0); } }
        public static double Days { get { return _elapsedTime / (60.0 * 60.0 * 24.0); } }
        public static double Months { get { return _elapsedTime / (60.0 * 60.0 * 24.0 * 30.0); } }
        public static double Years { get { return _elapsedTime / (60.0 * 60.0 * 24.0 * 30.0 * 12.0); } }
    }
}
