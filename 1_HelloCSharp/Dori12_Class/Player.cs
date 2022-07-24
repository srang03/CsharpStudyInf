using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dori12_Class
{
    class Player
    {
        public int iCount; // 플레이어 진행 횟수

        public int iSun; // 해 카드 값
        public int iStar; // 별 카드 값
        public int iMoon; // 달 카드 값
        public int iCardSum; // 카드 총합

        // 값 들을 더해서 값을 반환
        public int CardSum(int iSun, int iStar, int iMoon)
        {
            return iSun + iStar + iMoon;
        }

        public string ResultText()

        {
            this.iCardSum = iSun + iStar + iMoon;
            return $"해: {this.iSun}, 달: {this.iMoon}, 별: {this.iStar}의 합계는 {this.iCardSum}입니다.";
        }
    }
    
}
