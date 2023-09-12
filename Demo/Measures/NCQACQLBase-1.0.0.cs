using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
[CqlLibrary("NCQACQLBase", "1.0.0")]
public class NCQACQLBase_1_0_0
{


    internal CqlContext context;

    #region Cached values


    #endregion
    public NCQACQLBase_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");


    }
    #region Dependencies


    #endregion

    [CqlDeclaration("Sort Date Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Sort_Date_Intervals(IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        if ((intervals == null))
            return (new CqlInterval<CqlDate>[0]
 as IEnumerable<CqlInterval<CqlDate>>);

        else if ((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDate>>(intervals) as object), 
				(((int?)0) as object)) ?? false))
            return (new CqlInterval<CqlDate>[0]
 as IEnumerable<CqlInterval<CqlDate>>);

        else 
            {
                Func<CqlInterval<CqlDate>,Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA> c__ = (I) => 
                {
                    var a__ = I;
                    var b__ = (((context?.Operators.Start(I) == null))
						? (context?.Operators.Minimum<CqlDate>())
						: (context?.Operators.Start(I)))
;
                    return new Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA
					{
						interval = a__,
						startOfInterval = b__,
					};
                };
                var d__ = context?.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(intervals, 
					c__);
                Func<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA,object> e__ = (@this) => @this?.startOfInterval;
                var f__ = context?.Operators.ListSortBy<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA>(d__, 
					e__, 
					System.ComponentModel.ListSortDirection.Ascending);
                Func<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA,CqlInterval<CqlDate>> g__ = (sortedIntervals) => 
                {
                    return sortedIntervals?.interval;
                };
                return context?.Operators.SelectOrNull<Tuples.Tuple_DXgGhLJSUaCHQXWCIGhOfjCeA, CqlInterval<CqlDate>>(f__, 
					g__);
            }
    }


    [CqlDeclaration("Sort DateTime Intervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        if ((intervals == null))
            return (new CqlInterval<CqlDateTime>[0]
 as IEnumerable<CqlInterval<CqlDateTime>>);

        else if ((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDateTime>>(intervals) as object), 
				(((int?)0) as object)) ?? false))
            return (new CqlInterval<CqlDateTime>[0]
 as IEnumerable<CqlInterval<CqlDateTime>>);

        else 
            {
                Func<CqlInterval<CqlDateTime>,Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ> c__ = (I) => 
                {
                    var a__ = I;
                    var b__ = (((context?.Operators.Start(I) == null))
						? (context?.Operators.Minimum<CqlDateTime>())
						: (context?.Operators.Start(I)))
;
                    return new Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ
					{
						interval = a__,
						startOfInterval = b__,
					};
                };
                var d__ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(intervals, 
					c__);
                Func<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ,object> e__ = (@this) => @this?.startOfInterval;
                var f__ = context?.Operators.ListSortBy<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ>(d__, 
					e__, 
					System.ComponentModel.ListSortDirection.Ascending);
                Func<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ,CqlInterval<CqlDateTime>> g__ = (sortedIntervals) => 
                {
                    return sortedIntervals?.interval;
                };
                return context?.Operators.SelectOrNull<Tuples.Tuple_UKiMhSTCRNIPefSbODPWDGLQ, CqlInterval<CqlDateTime>>(f__, 
					g__);
            }
    }


    [CqlDeclaration("Collapse Date Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        if ((intervals == null))
            return (new CqlInterval<CqlDate>[0]
 as IEnumerable<CqlInterval<CqlDate>>);

        else if ((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDate>>(intervals) as object), 
				(((int?)0) as object)) ?? false))
            return (new CqlInterval<CqlDate>[0]
 as IEnumerable<CqlInterval<CqlDate>>);

        else 
            {
                Func<CqlInterval<CqlDate>,bool?> d__ = (I) => 
                {
                    Func<CqlInterval<CqlDate>,bool?> a__ = (J) => 
                    {
                        return context?.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, 
							I, 
							null);
                    };
                    var b__ = context?.Operators.SelectOrNull<CqlInterval<CqlDate>, bool?>(intervals, 
						a__);
                    var c__ = context?.Operators.AnyTrue(b__);
                    return context?.Operators.Not(c__);
                };
                var e__ = context?.Operators.WhereOrNull<CqlInterval<CqlDate>>(intervals, 
					d__);
                return context?.Operators.Collapse(e__, 
					"day");
            }
    }


    [CqlDeclaration("Collapse DateTime Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        if ((intervals == null))
            return (new CqlInterval<CqlDateTime>[0]
 as IEnumerable<CqlInterval<CqlDateTime>>);

        else if ((context?.Operators.Equal((context?.Operators.CountOrNull<CqlInterval<CqlDateTime>>(intervals) as object), 
				(((int?)0) as object)) ?? false))
            return (new CqlInterval<CqlDateTime>[0]
 as IEnumerable<CqlInterval<CqlDateTime>>);

        else 
            {
                Func<CqlInterval<CqlDateTime>,bool?> d__ = (I) => 
                {
                    Func<CqlInterval<CqlDateTime>,bool?> a__ = (J) => 
                    {
                        return context?.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, 
							I, 
							null);
                    };
                    var b__ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, bool?>(intervals, 
						a__);
                    var c__ = context?.Operators.AnyTrue(b__);
                    return context?.Operators.Not(c__);
                };
                var e__ = context?.Operators.WhereOrNull<CqlInterval<CqlDateTime>>(intervals, 
					d__);
                return context?.Operators.Collapse(e__, 
					null);
            }
    }


    [CqlDeclaration("Date Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        var a_ = this.Sort_Date_Intervals(coveringIntervals);
        Func<CqlInterval<CqlDate>,CqlInterval<CqlDate>> b_ = (sortedInterval) => 
        {
            return context?.Operators.IntervalIntersectsInterval<CqlDate>(baseInterval, 
				sortedInterval);
        };
        var c_ = context?.Operators.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(a_, 
			b_);
        return this.Collapse_Date_Interval_Workaround(c_);
    }

    [CqlDeclaration("DateTime Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        var a_ = this.Sort_DateTime_Intervals(coveringIntervals);
        Func<CqlInterval<CqlDateTime>,CqlInterval<CqlDateTime>> b_ = (sortedInterval) => 
        {
            return context?.Operators.IntervalIntersectsInterval<CqlDateTime>(baseInterval, 
				sortedInterval);
        };
        var c_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, 
			b_);
        return this.Collapse_DateTime_Interval_Workaround(c_);
    }

    [CqlDeclaration("Date Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        var c_ = this.Date_Interval_Covering_Relative_to_Base_Interval(baseInterval, 
			coveringIntervals);
        var b_ = new Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS
		{
			sortedCoverings = c_,
		};
        var a_ = new Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS[]
		{
			b_,
		};
        Func<Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS,IEnumerable<CqlInterval<CqlDate>>> ae_ = (variableDeclarations) => 
        {
            var h_ = variableDeclarations?.sortedCoverings;
            var g_ = (context?.Operators.CountOrNull<CqlInterval<CqlDate>>(h_) as object);
            var i_ = (((int?)0) as object);
            var j_ = baseInterval;
            Func<CqlInterval<CqlDate>,CqlInterval<CqlDate>> l_ = (sortedCovering) => (((context?.Operators.Equal((context?.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, 
						sortedCovering) as object), 
					(((int?)0) as object)) ?? false))
					? (context?.Operators.IntervalExcept(context?.Operators.IntervalIntersectsInterval<CqlDate>(context?.Operators.Interval(context?.Operators.Start(baseInterval), 
									context?.Operators.Start(sortedCovering), 
									true, 
									true), 
								baseInterval), 
							sortedCovering))
					: (context?.Operators.IntervalExcept(context?.Operators.IntervalExcept(context?.Operators.Interval(context?.Operators.Start(context?.Operators.ListElementAt<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, 
											context?.Operators.Subtract(context?.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, 
													sortedCovering), 
												((int?)1)))), 
									context?.Operators.End(sortedCovering), 
									false, 
									false), 
								context?.Operators.ListElementAt<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, 
									context?.Operators.Subtract(context?.Operators.ListIndex<CqlInterval<CqlDate>>(variableDeclarations?.sortedCoverings, 
											sortedCovering), 
										((int?)1)))), 
							sortedCovering)))
;
            var f_ = (((context?.Operators.Equal(g_, 
				i_) ?? false))
				? ((new CqlInterval<CqlDate>[]
					{
						j_,
					} as IEnumerable<CqlInterval<CqlDate>>))
				: (context?.Operators.SelectOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(h_, 
						l_)))
;
            var s_ = context?.Operators.LastOfList<CqlInterval<CqlDate>>(h_);
            var t_ = context?.Operators.Start(s_);
            var u_ = context?.Operators.End(baseInterval);
            var v_ = context?.Operators.Interval(t_, 
				u_, 
				false, 
				true);
            var y_ = context?.Operators.IntervalExcept(v_, 
				s_);
            var q_ = context?.Operators.IntervalIntersectsInterval<CqlDate>(y_, 
				baseInterval);
            var m_ = (((context?.Operators.Equal(g_, 
				i_) ?? false))
				? ((new CqlInterval<CqlDate>[0]
 as IEnumerable<CqlInterval<CqlDate>>))
				: ((new CqlInterval<CqlDate>[]
					{
						q_,
					} as IEnumerable<CqlInterval<CqlDate>>)))
;
            var e_ = new Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR
			{
				frontgaps = f_,
				endgap = m_,
			};
            var d_ = new Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR[]
			{
				e_,
			};
            Func<Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR,IEnumerable<CqlInterval<CqlDate>>> ac_ = (calculations) => 
            {
                var z_ = calculations?.frontgaps;
                var aa_ = calculations?.endgap;
                var ab_ = context?.Operators.ListUnion<CqlInterval<CqlDate>>(z_, 
					aa_);
                return this.Collapse_Date_Interval_Workaround(ab_);
            };
            var ad_ = context?.Operators.SelectOrNull<Tuples.Tuple_FXGMiYhHaiIMEGdRUYMPEAHCR, IEnumerable<CqlInterval<CqlDate>>>(d_, 
				ac_);
            return context?.Operators.SingleOrNull<IEnumerable<CqlInterval<CqlDate>>>(ad_);
        };
        var af_ = context?.Operators.SelectOrNull<Tuples.Tuple_EHUBiUYZGHNGdhCYfLiYVfUdS, IEnumerable<CqlInterval<CqlDate>>>(a_, 
			ae_);
        return context?.Operators.SingleOrNull<IEnumerable<CqlInterval<CqlDate>>>(af_);
    }

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        var c_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, 
			coveringIntervals);
        var b_ = new Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ
		{
			sortedCoverings = c_,
		};
        var a_ = new Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ[]
		{
			b_,
		};
        Func<Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ,IEnumerable<CqlInterval<CqlDateTime>>> ae_ = (variableDeclarations) => 
        {
            var h_ = variableDeclarations?.sortedCoverings;
            var g_ = (context?.Operators.CountOrNull<CqlInterval<CqlDateTime>>(h_) as object);
            var i_ = (((int?)0) as object);
            var j_ = baseInterval;
            Func<CqlInterval<CqlDateTime>,CqlInterval<CqlDateTime>> l_ = (sortedCovering) => (((context?.Operators.Equal((context?.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, 
						sortedCovering) as object), 
					(((int?)0) as object)) ?? false))
					? (context?.Operators.IntervalExcept(context?.Operators.IntervalIntersectsInterval<CqlDateTime>(context?.Operators.Interval(context?.Operators.Start(baseInterval), 
									context?.Operators.Start(sortedCovering), 
									true, 
									true), 
								baseInterval), 
							sortedCovering))
					: (context?.Operators.IntervalExcept(context?.Operators.IntervalExcept(context?.Operators.Interval(context?.Operators.Start(context?.Operators.ListElementAt<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, 
											context?.Operators.Subtract(context?.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, 
													sortedCovering), 
												((int?)1)))), 
									context?.Operators.End(sortedCovering), 
									false, 
									false), 
								context?.Operators.ListElementAt<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, 
									context?.Operators.Subtract(context?.Operators.ListIndex<CqlInterval<CqlDateTime>>(variableDeclarations?.sortedCoverings, 
											sortedCovering), 
										((int?)1)))), 
							sortedCovering)))
;
            var f_ = (((context?.Operators.Equal(g_, 
				i_) ?? false))
				? ((new CqlInterval<CqlDateTime>[]
					{
						j_,
					} as IEnumerable<CqlInterval<CqlDateTime>>))
				: (context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(h_, 
						l_)))
;
            var s_ = context?.Operators.LastOfList<CqlInterval<CqlDateTime>>(h_);
            var t_ = context?.Operators.Start(s_);
            var u_ = context?.Operators.End(baseInterval);
            var v_ = context?.Operators.Interval(t_, 
				u_, 
				false, 
				true);
            var y_ = context?.Operators.IntervalExcept(v_, 
				s_);
            var q_ = context?.Operators.IntervalIntersectsInterval<CqlDateTime>(y_, 
				baseInterval);
            var m_ = (((context?.Operators.Equal(g_, 
				i_) ?? false))
				? ((new CqlInterval<CqlDateTime>[0]
 as IEnumerable<CqlInterval<CqlDateTime>>))
				: ((new CqlInterval<CqlDateTime>[]
					{
						q_,
					} as IEnumerable<CqlInterval<CqlDateTime>>)))
;
            var e_ = new Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA
			{
				frontgaps = f_,
				endgap = m_,
			};
            var d_ = new Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA[]
			{
				e_,
			};
            Func<Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA,IEnumerable<CqlInterval<CqlDateTime>>> ac_ = (calculations) => 
            {
                var z_ = calculations?.frontgaps;
                var aa_ = calculations?.endgap;
                var ab_ = context?.Operators.ListUnion<CqlInterval<CqlDateTime>>(z_, 
					aa_);
                return this.Collapse_DateTime_Interval_Workaround(ab_);
            };
            var ad_ = context?.Operators.SelectOrNull<Tuples.Tuple_HAejSJNFdWPBCHgSSZUeVRIHA, IEnumerable<CqlInterval<CqlDateTime>>>(d_, 
				ac_);
            return context?.Operators.SingleOrNull<IEnumerable<CqlInterval<CqlDateTime>>>(ad_);
        };
        var af_ = context?.Operators.SelectOrNull<Tuples.Tuple_CUJFCVgQUNRcdHdTeVDjJcYaZ, IEnumerable<CqlInterval<CqlDateTime>>>(a_, 
			ae_);
        return context?.Operators.SingleOrNull<IEnumerable<CqlInterval<CqlDateTime>>>(af_);
    }

    [CqlDeclaration("Collapsed Date Interval Stats")]
    public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Collapsed_Date_Interval_Stats(IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
    {
        var a_ = collapsedIntervals;
        var b_ = context?.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals);
        var d_ = (context?.Operators.CountOrNull<CqlInterval<CqlDate>>(collapsedIntervals) as object);
        var e_ = (((int?)0) as object);
        Func<CqlInterval<CqlDate>,int?> l_ = (I) => 
        {
            var h_ = context?.Operators.Start(I);
            var i_ = context?.Operators.End(I);
            var j_ = context?.Operators.DurationBetween(h_, 
				i_, 
				"day");
            var g_ = context?.Operators.Add(j_, 
				((int?)1));
            int? k_ = ((int?)0);
            var f_ = (new int?[]
			{
				g_,
				k_,
			} as IEnumerable<int?>);
            return context?.Operators.MaxOrNull<int?>(f_);
        };
        var m_ = context?.Operators.SelectOrNull<CqlInterval<CqlDate>, int?>(collapsedIntervals, 
			l_);
        var c_ = (((context?.Operators.Equal(d_, 
			e_) ?? false))
			? (((int?)0))
			: (context?.Operators.Sum(m_)))
;
        var n_ = (((context?.Operators.Equal(d_, 
			e_) ?? false))
			? ((null as CqlInterval<CqlDate>))
			: ((context?.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context?.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context?.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, 
								(I) => new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
									{
										interval = I,
										days = context?.Operators.MaxOrNull<int?>((new int?[]
											{
												context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(I), 
														context?.Operators.End(I), 
														"day"), 
													((int?)1)),
												((int?)0),
											} as IEnumerable<int?>)),
									}), 
							(@this) => @this?.days, 
							System.ComponentModel.ListSortDirection.Descending)))?.interval))
;
        var v_ = (context?.Operators.FirstOfList<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context?.Operators.ListSortBy<Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(context?.Operators.SelectOrNull<CqlInterval<CqlDate>, Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU>(collapsedIntervals, 
						(I) => new Tuples.Tuple_ECVjLWJcUFIRQXFBcGfYDAJeU
							{
								interval = I,
								days = context?.Operators.MaxOrNull<int?>((new int?[]
									{
										context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(I), 
												context?.Operators.End(I), 
												"day"), 
											((int?)1)),
										((int?)0),
									} as IEnumerable<int?>)),
							}), 
					(@this) => @this?.days, 
					System.ComponentModel.ListSortDirection.Descending)))?.interval;
        var w_ = context?.Operators.Start(v_);
        var y_ = context?.Operators.End(v_);
        var z_ = context?.Operators.DurationBetween(w_, 
			y_, 
			"day");
        var u_ = context?.Operators.Add(z_, 
			((int?)1));
        int? aa_ = ((int?)0);
        var t_ = (new int?[]
		{
			u_,
			aa_,
		} as IEnumerable<int?>);
        var q_ = (((context?.Operators.Equal(d_, 
			e_) ?? false))
			? (((int?)0))
			: (context?.Operators.MaxOrNull<int?>(t_)))
;
        return new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD
		{
			Intervals = a_,
			Interval_Count = b_,
			Total_Days_In_Intervals = c_,
			Longest_Interval = n_,
			Total_Days_In_Longest_Interval = q_,
		};
    }

    [CqlDeclaration("Date Interval Covering Relative to Base Interval Stats")]
    public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        var c_ = this.Date_Interval_Covering_Relative_to_Base_Interval(baseInterval, 
			coveringIntervals);
        var b_ = new Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU
		{
			Covering_Intervals = c_,
		};
        var a_ = new Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU[]
		{
			b_,
		};
        Func<Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU,Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD> e_ = (variableDeclarations) => 
        {
            var d_ = variableDeclarations?.Covering_Intervals;
            return this.Collapsed_Date_Interval_Stats(d_);
        };
        var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_BiacLIDOWQWTUEhhUVDjWHeBU, Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(a_, 
			e_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(f_);
    }

    [CqlDeclaration("Date Interval Gaps Relative to Base Interval Stats")]
    public Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        var c_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(baseInterval, 
			coveringIntervals);
        var b_ = new Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG
		{
			Gap_Intervals = c_,
		};
        var a_ = new Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG[]
		{
			b_,
		};
        Func<Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG,Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD> e_ = (variableDeclarations) => 
        {
            var d_ = variableDeclarations?.Gap_Intervals;
            return this.Collapsed_Date_Interval_Stats(d_);
        };
        var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_EcPDQKeCFLjSYgUXJScRcgbKG, Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(a_, 
			e_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD>(f_);
    }

    [CqlDeclaration("DateTime Interval Set Nulls to Zero")]
    public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlInterval<CqlDateTime> interval)
    {
        var d_ = context?.Operators.Start(interval);
        var c_ = context?.Operators.ComponentFrom(d_, 
			"year");
        var e_ = (((context?.Operators.ComponentFrom(d_, 
			"month") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(d_, 
					"month")))
;
        var h_ = (((context?.Operators.ComponentFrom(d_, 
			"day") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(d_, 
					"day")))
;
        var k_ = (((context?.Operators.ComponentFrom(d_, 
			"hour") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(d_, 
					"hour")))
;
        var n_ = (((context?.Operators.ComponentFrom(d_, 
			"minute") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(d_, 
					"minute")))
;
        var q_ = (((context?.Operators.ComponentFrom(d_, 
			"second") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(d_, 
					"second")))
;
        var t_ = (((context?.Operators.ComponentFrom(d_, 
			"millisecond") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(d_, 
					"millisecond")))
;
        var x_ = context?.Operators.End(interval);
        var w_ = context?.Operators.ComponentFrom(x_, 
			"year");
        var y_ = (((context?.Operators.ComponentFrom(x_, 
			"month") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(x_, 
					"month")))
;
        var ab_ = (((context?.Operators.ComponentFrom(x_, 
			"day") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(x_, 
					"day")))
;
        var ae_ = (((context?.Operators.ComponentFrom(x_, 
			"hour") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(x_, 
					"hour")))
;
        var ah_ = (((context?.Operators.ComponentFrom(x_, 
			"minute") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(x_, 
					"minute")))
;
        var ak_ = (((context?.Operators.ComponentFrom(x_, 
			"second") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(x_, 
					"second")))
;
        var an_ = (((context?.Operators.ComponentFrom(x_, 
			"millisecond") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(x_, 
					"millisecond")))
;
        var b_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
		{
			StartYear = c_,
			StartMonth = e_,
			StartDay = h_,
			StartHour = k_,
			StartMinute = n_,
			StartSecond = q_,
			StartMillisecond = t_,
			EndYear = w_,
			EndMonth = y_,
			EndDay = ab_,
			EndHour = ae_,
			EndMinute = ah_,
			EndSecond = ak_,
			EndMillisecond = an_,
		};
        var a_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			b_,
		};
        Func<Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf,CqlInterval<CqlDateTime>> bi_ = (i) => 
        {
            var aq_ = i?.StartYear;
            var ar_ = i?.StartMonth;
            var as_ = i?.StartDay;
            var at_ = i?.StartHour;
            var au_ = i?.StartMinute;
            var av_ = i?.StartSecond;
            var aw_ = i?.StartMillisecond;
            var ax_ = context?.Operators.ConvertIntegerToDecimal(default);
            var ay_ = context?.Operators.DateTime(aq_, 
				ar_, 
				as_, 
				at_, 
				au_, 
				av_, 
				aw_, 
				ax_);
            var az_ = i?.EndYear;
            var ba_ = i?.EndMonth;
            var bb_ = i?.EndDay;
            var bc_ = i?.EndHour;
            var bd_ = i?.EndMinute;
            var be_ = i?.EndSecond;
            var bf_ = i?.EndMillisecond;
            var bh_ = context?.Operators.DateTime(az_, 
				ba_, 
				bb_, 
				bc_, 
				bd_, 
				be_, 
				bf_, 
				ax_);
            return context?.Operators.Interval(ay_, 
				bh_, 
				true, 
				true);
        };
        var bj_ = context?.Operators.SelectOrNull<Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlInterval<CqlDateTime>>(a_, 
			bi_);
        return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(bj_);
    }

    [CqlDeclaration("Collapsed DateTime Interval Stats")]
    public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO Collapsed_DateTime_Interval_Stats(IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
    {
        var a_ = collapsedIntervals;
        var b_ = context?.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals);
        var d_ = (context?.Operators.CountOrNull<CqlInterval<CqlDateTime>>(collapsedIntervals) as object);
        var e_ = (((int?)0) as object);
        Func<CqlInterval<CqlDateTime>,int?> n_ = (I) => 
        {
            var h_ = this.DateTime_Interval_Set_Nulls_to_Zero(I);
            var i_ = context?.Operators.Start(h_);
            var k_ = context?.Operators.End(h_);
            var l_ = context?.Operators.DurationBetween(i_, 
				k_, 
				"day");
            var g_ = context?.Operators.Add(l_, 
				((int?)1));
            int? m_ = ((int?)0);
            var f_ = (new int?[]
			{
				g_,
				m_,
			} as IEnumerable<int?>);
            return context?.Operators.MaxOrNull<int?>(f_);
        };
        var o_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, 
			n_);
        var c_ = (((context?.Operators.Equal(d_, 
			e_) ?? false))
			? (((int?)0))
			: (context?.Operators.Sum(o_)))
;
        var p_ = (((context?.Operators.Equal(d_, 
			e_) ?? false))
			? ((null as CqlInterval<CqlDateTime>))
			: ((context?.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context?.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, 
								(I) => new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
									{
										interval = I,
										days = context?.Operators.MaxOrNull<int?>((new int?[]
											{
												context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(this.DateTime_Interval_Set_Nulls_to_Zero(I)), 
														context?.Operators.End(this.DateTime_Interval_Set_Nulls_to_Zero(I)), 
														"day"), 
													((int?)1)),
												((int?)0),
											} as IEnumerable<int?>)),
									}), 
							(@this) => @this?.days, 
							System.ComponentModel.ListSortDirection.Descending)))?.interval))
;
        var x_ = (context?.Operators.FirstOfList<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context?.Operators.ListSortBy<Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW>(collapsedIntervals, 
						(I) => new Tuples.Tuple_GBYTHaefaUNajDZadEXbadOFW
							{
								interval = I,
								days = context?.Operators.MaxOrNull<int?>((new int?[]
									{
										context?.Operators.Add(context?.Operators.DurationBetween(context?.Operators.Start(this.DateTime_Interval_Set_Nulls_to_Zero(I)), 
												context?.Operators.End(this.DateTime_Interval_Set_Nulls_to_Zero(I)), 
												"day"), 
											((int?)1)),
										((int?)0),
									} as IEnumerable<int?>)),
							}), 
					(@this) => @this?.days, 
					System.ComponentModel.ListSortDirection.Descending)))?.interval;
        var y_ = this.DateTime_Interval_Set_Nulls_to_Zero(x_);
        var z_ = context?.Operators.Start(y_);
        var ac_ = context?.Operators.End(y_);
        var ad_ = context?.Operators.DurationBetween(z_, 
			ac_, 
			"day");
        var w_ = context?.Operators.Add(ad_, 
			((int?)1));
        int? ae_ = ((int?)0);
        var v_ = (new int?[]
		{
			w_,
			ae_,
		} as IEnumerable<int?>);
        var s_ = (((context?.Operators.Equal(d_, 
			e_) ?? false))
			? (((int?)0))
			: (context?.Operators.MaxOrNull<int?>(v_)))
;
        return new Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO
		{
			Intervals = a_,
			Interval_Count = b_,
			Total_Days_In_Intervals = c_,
			Longest_Interval = p_,
			Total_Days_In_Longest_Interval = s_,
		};
    }

    [CqlDeclaration("DateTime Interval Covering Relative to Base Interval Stats")]
    public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        var c_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(baseInterval, 
			coveringIntervals);
        var b_ = new Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY
		{
			Covering_Intervals = c_,
		};
        var a_ = new Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY[]
		{
			b_,
		};
        Func<Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY,Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO> e_ = (variableDeclarations) => 
        {
            var d_ = variableDeclarations?.Covering_Intervals;
            return this.Collapsed_DateTime_Interval_Stats(d_);
        };
        var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_CbDWBMGYObPdSJUZaIQTNfFXY, Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(a_, 
			e_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(f_);
    }

    [CqlDeclaration("DateTime Interval Gaps Relative to Base Interval Stats")]
    public Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        var c_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(baseInterval, 
			coveringIntervals);
        var b_ = new Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB
		{
			Gap_Intervals = c_,
		};
        var a_ = new Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB[]
		{
			b_,
		};
        Func<Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB,Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO> e_ = (variableDeclarations) => 
        {
            var d_ = variableDeclarations?.Gap_Intervals;
            return this.Collapsed_DateTime_Interval_Stats(d_);
        };
        var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_BdbDhEjXOINLgCRGiAFGdHJIB, Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(a_, 
			e_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_BhaRdDVNNUEZDBgSheMGTUMHO>(f_);
    }

    [CqlDeclaration("Convert To UTC DateTime")]
    public CqlDateTime Convert_To_UTC_DateTime(CqlDate d)
    {
        var c_ = context?.Operators.ComponentFrom(d, 
			"year");
        var d_ = (((context?.Operators.ComponentFrom(d, 
			"month") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(d, 
					"month")))
;
        var e_ = (((context?.Operators.ComponentFrom(d, 
			"day") == null))
			? (((int?)0))
			: (context?.Operators.ComponentFrom(d, 
					"day")))
;
        var b_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf
		{
			StartYear = c_,
			StartMonth = d_,
			StartDay = e_,
		};
        var a_ = new Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf[]
		{
			b_,
		};
        Func<Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf,CqlDateTime> j_ = (i) => 
        {
            var f_ = i?.StartYear;
            var g_ = i?.StartMonth;
            var h_ = i?.StartDay;
            var i_ = context?.Operators.ConvertIntegerToDecimal(((int?)0));
            return context?.Operators.DateTime(f_, 
				g_, 
				h_, 
				((int?)0), 
				((int?)0), 
				((int?)0), 
				((int?)0), 
				i_);
        };
        var k_ = context?.Operators.SelectOrNull<Tuples.Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf, CqlDateTime>(a_, 
			j_);
        return context?.Operators.SingleOrNull<CqlDateTime>(k_);
    }

    [CqlDeclaration("Convert Interval Date to UTC Interval DateTime")]
    public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlInterval<CqlDate> interval)
    {
        var a_ = context?.Operators.Start(interval);
        var b_ = this.Convert_To_UTC_DateTime(a_);
        var c_ = context?.Operators.End(interval);
        var d_ = this.Convert_To_UTC_DateTime(c_);
        return context?.Operators.Interval(b_, 
			d_, 
			true, 
			true);
    }

}