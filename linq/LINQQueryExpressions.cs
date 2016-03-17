class LINQQueryExpressions
{
    static void Main()
    {
        int[] scores = new int[] { 97, 92, 81, 60};
        
        IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            select score;
            
            // 정렬
            // https://msdn.microsoft.com/ko-kr/library/bb397927.aspx
            /*
            var queryLondonCustomers3 = 
                from cust in customers
                where cust.City == "London"
                orderby cust.Name ascending
                select cust;

            */
            
            
    }
}