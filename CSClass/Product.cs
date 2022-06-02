﻿namespace CSClass
{
    class Product
    {
        public static int counter=0;
        public static string MADEIN = "Korea";

        /// <summary>
        /// 상품 이름
        /// </summary>
        public string name = "무명";

        /// <summary>
        /// 상품 가격, 단위는 원
        /// </summary>
        public int price = 0;

        public Product()
        {
            counter++;
        }
    }
}