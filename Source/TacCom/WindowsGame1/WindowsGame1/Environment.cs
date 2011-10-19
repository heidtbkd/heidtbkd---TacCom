using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacCom
{
    public class Environment
    {
        private String name;
        private Object weatherAbility;

        public Environment(String weName, Object weather)
        {

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
