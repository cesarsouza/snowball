// This file was generated automatically by the Snowball to C# compiler

#pragma warning disable 0164
#pragma warning disable 0162

namespace Snowball
{
    using System;
    using System.Text;
    
    ///<summary>
    ///  This class was automatically generated by a Snowball to Java compiler 
    ///  It implements the stemming algorithm defined by a snowball script.
    ///</summary>
    /// 
    [System.CodeDom.Compiler.GeneratedCode("Snowball", "1.0.0")]
    public partial class German2Stemmer : SnowballStemmer
    {
        private int I_x;
        private int I_p2;
        private int I_p1;

        private static string g_v = "aeiouy\u00E4\u00F6\u00FC";
        private static string g_s_ending = "bdfghklmnrt";
        private static string g_st_ending = "bdfghklmnt";
        private readonly Among[] a_0;
        private readonly Among[] a_1;
        private readonly Among[] a_2;
        private readonly Among[] a_3;
        private readonly Among[] a_4;
        private readonly Among[] a_5;

        public German2Stemmer()
        {
            a_0 = new[] 
            {
                new Among("", -1, 6),
                new Among("ae", 0, 2),
                new Among("oe", 0, 3),
                new Among("qu", 0, 5),
                new Among("ue", 0, 4),
                new Among("\u00DF", 0, 1)
            };

            a_1 = new[] 
            {
                new Among("", -1, 6),
                new Among("U", 0, 2),
                new Among("Y", 0, 1),
                new Among("\u00E4", 0, 3),
                new Among("\u00F6", 0, 4),
                new Among("\u00FC", 0, 5)
            };

            a_2 = new[] 
            {
                new Among("e", -1, 2),
                new Among("em", -1, 1),
                new Among("en", -1, 2),
                new Among("ern", -1, 1),
                new Among("er", -1, 1),
                new Among("s", -1, 3),
                new Among("es", 5, 2)
            };

            a_3 = new[] 
            {
                new Among("en", -1, 1),
                new Among("er", -1, 1),
                new Among("st", -1, 2),
                new Among("est", 2, 1)
            };

            a_4 = new[] 
            {
                new Among("ig", -1, 1),
                new Among("lich", -1, 1)
            };

            a_5 = new[] 
            {
                new Among("end", -1, 1),
                new Among("ig", -1, 2),
                new Among("ung", -1, 1),
                new Among("lich", -1, 3),
                new Among("isch", -1, 2),
                new Among("ik", -1, 2),
                new Among("heit", -1, 3),
                new Among("keit", -1, 4)
            };

        }



        private int r_prelude()
        {
            int among_var;
            // (, line 33
            // test, line 35
            {
                int c1 = cursor;
                // repeat, line 35
                while (true)
                {
                    int c2 = cursor;
                    while (true)
                    {
                        // goto, line 35
                        int c3 = cursor;
                        // (, line 35
                        if (in_grouping(g_v, 97, 252, false) != 0)
                        {
                            goto lab1;
                        }
                        // [, line 36
                        bra = cursor;
                        // or, line 36
                        {
                            int c4 = cursor;
                            // (, line 36
                            // literal, line 36
                            if (!(eq_s("u")))
                            {
                                goto lab3;
                            }
                            // ], line 36
                            ket = cursor;
                            if (in_grouping(g_v, 97, 252, false) != 0)
                            {
                                goto lab3;
                            }
                            // <-, line 36
                            slice_from("U");
                            goto lab2;
                        lab3: ; 
                            cursor = c4;
                            // (, line 37
                            // literal, line 37
                            if (!(eq_s("y")))
                            {
                                goto lab1;
                            }
                            // ], line 37
                            ket = cursor;
                            if (in_grouping(g_v, 97, 252, false) != 0)
                            {
                                goto lab1;
                            }
                            // <-, line 37
                            slice_from("Y");
                        }
                    lab2: ; 
                        cursor = c3;
                        break;
                    lab1: ; 
                        cursor = c3;
                        // goto, line 35
                        if (cursor >= limit)
                        {
                            goto lab0;
                        }
                        cursor++;
                    }
                    continue;
                lab0: ; 
                    cursor = c2;
                    break;
                }
                cursor = c1;
            }
            // repeat, line 40
            while (true)
            {
                int c5 = cursor;
                // (, line 40
                // [, line 41
                bra = cursor;
                // substring, line 41
                among_var = find_among(a_0);
                if (among_var == 0)
                {
                    goto lab4;
                }
                // ], line 41
                ket = cursor;
                switch (among_var) 
                {
                    case 0:
                        {
                            goto lab4;
                        }
                    case 1:
                        // (, line 42
                        // <-, line 42
                        slice_from("ss");
                        break;
                    case 2:
                        // (, line 43
                        // <-, line 43
                        slice_from("\u00E4");
                        break;
                    case 3:
                        // (, line 44
                        // <-, line 44
                        slice_from("\u00F6");
                        break;
                    case 4:
                        // (, line 45
                        // <-, line 45
                        slice_from("\u00FC");
                        break;
                    case 5:
                        // (, line 46
                        // hop, line 46
                        {
                            int ret = cursor + 2;
                            if (0 > ret || ret > limit)
                            {
                                goto lab4;
                            }
                            cursor = ret;
                        }
                        break;
                    case 6:
                        // (, line 47
                        // next, line 47
                        if (cursor >= limit)
                        {
                            goto lab4;
                        }
                        cursor++;
                        break;
                }
                continue;
            lab4: ; 
                cursor = c5;
                break;
            }

            return 1;
        }

        private int r_mark_regions()
        {
            // (, line 53
            I_p1 = limit;
            I_p2 = limit;
            // test, line 58
            {
                int c1 = cursor;
                // (, line 58
                // hop, line 58
                {
                    int ret = cursor + 3;
                    if (0 > ret || ret > limit)
                    {
                        return 0;
                    }
                    cursor = ret;
                }
                // setmark x, line 58
                I_x = cursor;
                cursor = c1;
            }
            {
                /* gopast */ 
                int ret = out_grouping(g_v, 97, 252, true);
                if (ret < 0)
                {
                    return 0;
                }

                cursor += ret;
            }
            {
                /* gopast */ 
                int ret = in_grouping(g_v, 97, 252, true);
                if (ret < 0)
                {
                    return 0;
                }

                cursor += ret;
            }
            // setmark p1, line 60
            I_p1 = cursor;
            // try, line 61
            // (, line 61
            if (!(I_p1 < I_x))
            {
                goto lab0;
            }
            I_p1 = I_x;
        lab0: ; 
            {
                /* gopast */ 
                int ret = out_grouping(g_v, 97, 252, true);
                if (ret < 0)
                {
                    return 0;
                }

                cursor += ret;
            }
            {
                /* gopast */ 
                int ret = in_grouping(g_v, 97, 252, true);
                if (ret < 0)
                {
                    return 0;
                }

                cursor += ret;
            }
            // setmark p2, line 62
            I_p2 = cursor;

            return 1;
        }

        private int r_postlude()
        {
            int among_var;
            // repeat, line 66
            while (true)
            {
                int c1 = cursor;
                // (, line 66
                // [, line 68
                bra = cursor;
                // substring, line 68
                among_var = find_among(a_1);
                if (among_var == 0)
                {
                    goto lab0;
                }
                // ], line 68
                ket = cursor;
                switch (among_var) 
                {
                    case 0:
                        {
                            goto lab0;
                        }
                    case 1:
                        // (, line 69
                        // <-, line 69
                        slice_from("y");
                        break;
                    case 2:
                        // (, line 70
                        // <-, line 70
                        slice_from("u");
                        break;
                    case 3:
                        // (, line 71
                        // <-, line 71
                        slice_from("a");
                        break;
                    case 4:
                        // (, line 72
                        // <-, line 72
                        slice_from("o");
                        break;
                    case 5:
                        // (, line 73
                        // <-, line 73
                        slice_from("u");
                        break;
                    case 6:
                        // (, line 74
                        // next, line 74
                        if (cursor >= limit)
                        {
                            goto lab0;
                        }
                        cursor++;
                        break;
                }
                continue;
            lab0: ; 
                cursor = c1;
                break;
            }

            return 1;
        }

        private int r_R1()
        {
            if (!(I_p1 <= cursor))
            {
                return 0;
            }

            return 1;
        }

        private int r_R2()
        {
            if (!(I_p2 <= cursor))
            {
                return 0;
            }

            return 1;
        }

        private int r_standard_suffix()
        {
            int among_var;
            // (, line 84
            // do, line 85
            {
                int c1 = limit - cursor;
                // (, line 85
                // [, line 86
                ket = cursor;
                // substring, line 86
                among_var = find_among_b(a_2);
                if (among_var == 0)
                {
                    goto lab0;
                }
                // ], line 86
                bra = cursor;
                {
                    // call R1, line 86
                    int ret = r_R1();
                    if (ret == 0)
                        goto lab0;
                    else if (ret < 0)
                        return ret;
                }
                switch (among_var) 
                {
                    case 0:
                        {
                            goto lab0;
                        }
                    case 1:
                        // (, line 88
                        // delete, line 88
                        slice_del();
                        break;
                    case 2:
                        // (, line 91
                        // delete, line 91
                        slice_del();
                        // try, line 92
                        {
                            int c2 = limit - cursor;
                            // (, line 92
                            // [, line 92
                            ket = cursor;
                            // literal, line 92
                            if (!(eq_s_b("s")))
                            {
                                {
                                    cursor = limit - c2;
                                    goto lab1;
                                }
                            }
                            // ], line 92
                            bra = cursor;
                            // literal, line 92
                            if (!(eq_s_b("nis")))
                            {
                                {
                                    cursor = limit - c2;
                                    goto lab1;
                                }
                            }
                            // delete, line 92
                            slice_del();
                        lab1: ; 
                        }
                        break;
                    case 3:
                        // (, line 95
                        if (in_grouping_b(g_s_ending, 98, 116, false) != 0)
                        {
                            goto lab0;
                        }
                        // delete, line 95
                        slice_del();
                        break;
                }
            lab0: ; 
                cursor = limit - c1;
            }
            // do, line 99
            {
                int c3 = limit - cursor;
                // (, line 99
                // [, line 100
                ket = cursor;
                // substring, line 100
                among_var = find_among_b(a_3);
                if (among_var == 0)
                {
                    goto lab2;
                }
                // ], line 100
                bra = cursor;
                {
                    // call R1, line 100
                    int ret = r_R1();
                    if (ret == 0)
                        goto lab2;
                    else if (ret < 0)
                        return ret;
                }
                switch (among_var) 
                {
                    case 0:
                        {
                            goto lab2;
                        }
                    case 1:
                        // (, line 102
                        // delete, line 102
                        slice_del();
                        break;
                    case 2:
                        // (, line 105
                        if (in_grouping_b(g_st_ending, 98, 116, false) != 0)
                        {
                            goto lab2;
                        }
                        // hop, line 105
                        {
                            int ret = cursor - 3;
                            if (limit_backward > ret || ret > limit)
                            {
                                goto lab2;
                            }
                            cursor = ret;
                        }
                        // delete, line 105
                        slice_del();
                        break;
                }
            lab2: ; 
                cursor = limit - c3;
            }
            // do, line 109
            {
                int c4 = limit - cursor;
                // (, line 109
                // [, line 110
                ket = cursor;
                // substring, line 110
                among_var = find_among_b(a_5);
                if (among_var == 0)
                {
                    goto lab3;
                }
                // ], line 110
                bra = cursor;
                {
                    // call R2, line 110
                    int ret = r_R2();
                    if (ret == 0)
                        goto lab3;
                    else if (ret < 0)
                        return ret;
                }
                switch (among_var) 
                {
                    case 0:
                        {
                            goto lab3;
                        }
                    case 1:
                        // (, line 112
                        // delete, line 112
                        slice_del();
                        // try, line 113
                        {
                            int c5 = limit - cursor;
                            // (, line 113
                            // [, line 113
                            ket = cursor;
                            // literal, line 113
                            if (!(eq_s_b("ig")))
                            {
                                {
                                    cursor = limit - c5;
                                    goto lab4;
                                }
                            }
                            // ], line 113
                            bra = cursor;
                            // not, line 113
                            {
                                int c6 = limit - cursor;
                                // literal, line 113
                                if (!(eq_s_b("e")))
                                {
                                    goto lab5;
                                }
                                {
                                    cursor = limit - c5;
                                    goto lab4;
                                }
                            lab5: ; 
                                cursor = limit - c6;
                            }
                            {
                                // call R2, line 113
                                int ret = r_R2();
                                if (ret == 0)
                                    {
                                        cursor = limit - c5;
                                        goto lab4;
                                    }
                                else if (ret < 0)
                                    return ret;
                            }
                            // delete, line 113
                            slice_del();
                        lab4: ; 
                        }
                        break;
                    case 2:
                        // (, line 116
                        // not, line 116
                        {
                            int c7 = limit - cursor;
                            // literal, line 116
                            if (!(eq_s_b("e")))
                            {
                                goto lab6;
                            }
                            goto lab3;
                        lab6: ; 
                            cursor = limit - c7;
                        }
                        // delete, line 116
                        slice_del();
                        break;
                    case 3:
                        // (, line 119
                        // delete, line 119
                        slice_del();
                        // try, line 120
                        {
                            int c8 = limit - cursor;
                            // (, line 120
                            // [, line 121
                            ket = cursor;
                            // or, line 121
                            {
                                int c9 = limit - cursor;
                                // literal, line 121
                                if (!(eq_s_b("er")))
                                {
                                    goto lab9;
                                }
                                goto lab8;
                            lab9: ; 
                                cursor = limit - c9;
                                // literal, line 121
                                if (!(eq_s_b("en")))
                                {
                                    {
                                        cursor = limit - c8;
                                        goto lab7;
                                    }
                                }
                            }
                        lab8: ; 
                            // ], line 121
                            bra = cursor;
                            {
                                // call R1, line 121
                                int ret = r_R1();
                                if (ret == 0)
                                    {
                                        cursor = limit - c8;
                                        goto lab7;
                                    }
                                else if (ret < 0)
                                    return ret;
                            }
                            // delete, line 121
                            slice_del();
                        lab7: ; 
                        }
                        break;
                    case 4:
                        // (, line 125
                        // delete, line 125
                        slice_del();
                        // try, line 126
                        {
                            int c10 = limit - cursor;
                            // (, line 126
                            // [, line 127
                            ket = cursor;
                            // substring, line 127
                            among_var = find_among_b(a_4);
                            if (among_var == 0)
                            {
                                {
                                    cursor = limit - c10;
                                    goto lab10;
                                }
                            }
                            // ], line 127
                            bra = cursor;
                            {
                                // call R2, line 127
                                int ret = r_R2();
                                if (ret == 0)
                                    {
                                        cursor = limit - c10;
                                        goto lab10;
                                    }
                                else if (ret < 0)
                                    return ret;
                            }
                            switch (among_var) 
                            {
                                case 0:
                                    {
                                        {
                                            cursor = limit - c10;
                                            goto lab10;
                                        }
                                    }
                                case 1:
                                    // (, line 129
                                    // delete, line 129
                                    slice_del();
                                    break;
                            }
                        lab10: ; 
                        }
                        break;
                }
            lab3: ; 
                cursor = limit - c4;
            }

            return 1;
        }

        private int stem()
        {
            // (, line 139
            // do, line 140
            {
                int c1 = cursor;
                {
                    // call prelude, line 140
                    int ret = r_prelude();
                    if (ret == 0)
                        goto lab0;
                    else if (ret < 0)
                        return ret;
                }
            lab0: ; 
                cursor = c1;
            }
            // do, line 141
            {
                int c2 = cursor;
                {
                    // call mark_regions, line 141
                    int ret = r_mark_regions();
                    if (ret == 0)
                        goto lab1;
                    else if (ret < 0)
                        return ret;
                }
            lab1: ; 
                cursor = c2;
            }
            // backwards, line 142
            limit_backward = cursor; cursor = limit;
            // do, line 143
            {
                int c3 = limit - cursor;
                {
                    // call standard_suffix, line 143
                    int ret = r_standard_suffix();
                    if (ret == 0)
                        goto lab2;
                    else if (ret < 0)
                        return ret;
                }
            lab2: ; 
                cursor = limit - c3;
            }
            cursor = limit_backward;
            // do, line 144
            {
                int c4 = cursor;
                {
                    // call postlude, line 144
                    int ret = r_postlude();
                    if (ret == 0)
                        goto lab3;
                    else if (ret < 0)
                        return ret;
                }
            lab3: ; 
                cursor = c4;
            }

            return 1;
        }

        protected override bool Process()
        {
            return this.stem() > 0;
        }

    }
}

