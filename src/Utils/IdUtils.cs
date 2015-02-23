using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.Utils {

    public static class IdUtils {

        static int currId = 0;
        static List<int> usedIds = new List<int>();

        public static int PeekCurrentId {
            get { return IdUtils.currId; }
        }

        public static int CurrentId {
            get {
                IdUtils.usedIds.Add(IdUtils.currId);
                return IdUtils.currId++;
            }
        }

        public static bool IsUsedId(int id) {
            return IdUtils.usedIds.Contains(id);
        }

        public static void AddUsedId(int id) {
            IdUtils.usedIds.Add(id);
        }
    }
}
