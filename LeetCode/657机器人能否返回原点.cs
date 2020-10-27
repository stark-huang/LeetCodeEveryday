using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _657机器人能否返回原点
    {
        public bool JudgeCircle(string moves)
        {
            int R, L, U, D = 0;
            R = moves.Length - moves.Replace("R", "").Length;
            L = moves.Length - moves.Replace("L", "").Length;
            U = moves.Length - moves.Replace("U", "").Length;
            D = moves.Length - moves.Replace("D", "").Length;
            if (R == L && U == D)
                return true;
            else
                return false;
        }
        public bool JudgeCircle2(string moves)
        {
            int x = 0, y = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i])
                {
                    case 'R': x--; break;
                    case 'L': x++; break;
                    case 'U': y--; break;
                    case 'D': y++; break;
                    default: break;
                }
            }
            return x == 0 && y == 0;
        }
    }
}
