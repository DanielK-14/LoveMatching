using System.Collections.Generic;

namespace Logic
{
    /// <summary>
    /// Part of the Chain of Resposability pattern.
    /// Building the filters by the order that we decided is critical.
    /// Order: Critical filters and than Optional Filters.
    /// 
    /// Each filter is an ConcreteStrategy.
    /// </summary>
    public static class ChainOfHandlers
    {
        private static readonly Dictionary<eFilters, IFilterStrategy> sr_StringToOptionalFilterTest = new Dictionary<eFilters, IFilterStrategy>();

        private static readonly LinkedList<IFilterStrategy> sr_CriticalFilterTests = new LinkedList<IFilterStrategy>();

        public enum eFilters
        {
            Educated,
            WorkExperience,
            Popular,
            SameReligion,
            SameTown
        }

        static ChainOfHandlers()
        {
            sr_StringToOptionalFilterTest.Add(eFilters.Educated, new EducatedFriendsFilterStrategy());
            sr_StringToOptionalFilterTest.Add(eFilters.WorkExperience, new WorkExpFriendsFilterStrategy());
            sr_StringToOptionalFilterTest.Add(eFilters.Popular, new PopularFriendsFilterStrategy());
            sr_StringToOptionalFilterTest.Add(eFilters.SameReligion, new SameReligionFilterStrategy());
            sr_StringToOptionalFilterTest.Add(eFilters.SameTown, new SameTownFilterStrategy());

            sr_CriticalFilterTests.AddLast(new IntrestedInEachOtherFilterStrategy());
            sr_CriticalFilterTests.AddLast(new SingleFilterStrategy());
        }

        public static FriendFilter Build(LinkedList<eFilters> i_ListOfOptionalFiltersToAdd)
        {
            FriendFilter firstInChain = null;
            foreach(IFilterStrategy criticalFilterTest in sr_CriticalFilterTests)
            {
                if (firstInChain == null)
                {
                    firstInChain = new CriticalFilter(criticalFilterTest);
                }
                else
                {
                    firstInChain.AddToEndOfChain(new CriticalFilter(criticalFilterTest));
                }
            }

            foreach(eFilters nameOfOptionalFilter in i_ListOfOptionalFiltersToAdd)
            {
                IFilterStrategy optionalFilterTest = sr_StringToOptionalFilterTest[nameOfOptionalFilter];

                if (firstInChain == null)
                {
                    firstInChain = new OptionalFilter(optionalFilterTest);
                }
                else
                {
                    firstInChain.AddToEndOfChain(new OptionalFilter(optionalFilterTest));
                }
            }

            return firstInChain;
        }
    }
}
