using System;
using System.Collections.Generic;
using System.Text;

namespace projectPracticeSecond
{
    internal class ContractData
    {
        //고객명, 누적체결금액, 담당자명, 담당자 전화번호,
        //만기날짜, 상품명, 은행계좌번호,입금날짜,전화번호,체결금액 순
        public string 고객명 { get; set; }//CustomerName
        public string 누적체결금액 { get; set; }//CumulativeAmount
        public string 담당자명 { get; set; }//Manager
        public string 담당자전화번호 { get; set; }//ManagerPhone
        public string 만기날짜 { get; set; }//ExpiredDate
        public string 상품명 { get; set; }//ProductName
        public string 은행계좌번호 { get; set; }//BankAccountNum
        public string 입금날짜 { get; set; }//DepositDate
        public string 전화번호 { get; set; }//PhoneNum
        public string 체결금액 { get; set; }//Amount
    }
}
