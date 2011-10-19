using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacCom
{
    public class Environments
    {
        private String name;
        private Object weatherAbility;

        public Environments(String weName, Object weather)
        {
            name = weName;
            weatherAbility = weather;
        }

        public String getEnvName()
        {
            return name;
        }

        public Object getWeatherAbility()
        {
            return weatherAbility;
        }
    }
}
