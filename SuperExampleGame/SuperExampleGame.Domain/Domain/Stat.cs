using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperExampleGame.Domain.Domain
{
    public class Stat
    {
        private Levels _level;
        private int _grade;

        public Stat()
        {
            _level = Levels.Bronze;
            _grade = 1;
        }

        private void UpgradeLevel()
        {
            switch (_level)
            {
                case Levels.Bronze:
                    _level = Levels.Silver;
                    ResetGrade();
                    break;
                case Levels.Silver:
                    _level = Levels.Gold;
                    ResetGrade();
                    break;
                case Levels.Gold:
                    _level = Levels.Platinum;
                    ResetGrade();
                    break;
                case Levels.Platinum:
                    _level = Levels.Diamond;
                    ResetGrade();
                    break;
            }
        }

        private bool GradeIsAtMax()
        {
            return _grade > 10;
        }

        private void ResetGrade()
        {
            _grade = 1;
        }

        public void UpgradeGrade()
        {
            _grade++;
            if (GradeIsAtMax())
            {
                UpgradeLevel();
            }
        }

        public int GetGrade()
        {
            return _grade;
        }
    }
}
