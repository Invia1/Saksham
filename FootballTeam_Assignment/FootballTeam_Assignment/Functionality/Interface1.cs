using FootballTeam_Assignment.Model;
using System;
using System.Collections.Generic;

namespace FootballTeam_Assignment
{
    internal interface Interface1
    {
        int addname(PDetails pname);
        int delete_at(int n);
        List<PDetails> fetch_all();
        void update();
        void Search(PDetails searchingg);

    }
}
