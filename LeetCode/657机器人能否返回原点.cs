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

        作者：chao-yuan-v
        链接：https://leetcode-cn.com/problems/robot-return-to-origin/solution/c-ji-qi-ren-hui-dao-yuan-dian-by-chao-yuan-v/
来源：力扣（LeetCode）
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
    }
}
