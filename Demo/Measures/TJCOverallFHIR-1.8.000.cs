using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
[CqlLibrary("TJCOverallFHIR", "1.8.000")]
public class TJCOverallFHIR_1_8_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Comfort_Measures;
    internal Lazy<CqlValueSet> __Discharge_To_Acute_Care_Facility;
    internal Lazy<CqlValueSet> __Discharged_to_Health_Care_Facility_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Discharged_to_Home_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Hemorrhagic_Stroke;
    internal Lazy<CqlValueSet> __Ischemic_Stroke;
    internal Lazy<CqlValueSet> __Left_Against_Medical_Advice;
    internal Lazy<CqlValueSet> __Non_Elective_Inpatient;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlValueSet> __Patient_Expired;
    internal Lazy<CqlValueSet> __Ticagrelor_Therapy;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Non_Elective_Inpatient_Encounter;
    internal Lazy<IEnumerable<Encounter>> __All_Stroke_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Principal_Diagnosis_and_Age;
    internal Lazy<IEnumerable<Encounter>> __Ischemic_Stroke_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Ischemic_Stroke_Encounters_with_Discharge_Disposition;
    internal Lazy<IEnumerable<object>> __Intervention_Comfort_Measures;
    internal Lazy<IEnumerable<Encounter>> __Comfort_Measures_during_Hospitalization;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Comfort_Measures_during_Hospitalization;

    #endregion
    public TJCOverallFHIR_1_8_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __Comfort_Measures = new Lazy<CqlValueSet>(this.Comfort_Measures_Value);
        __Discharge_To_Acute_Care_Facility = new Lazy<CqlValueSet>(this.Discharge_To_Acute_Care_Facility_Value);
        __Discharged_to_Health_Care_Facility_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Health_Care_Facility_for_Hospice_Care_Value);
        __Discharged_to_Home_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Home_for_Hospice_Care_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Hemorrhagic_Stroke = new Lazy<CqlValueSet>(this.Hemorrhagic_Stroke_Value);
        __Ischemic_Stroke = new Lazy<CqlValueSet>(this.Ischemic_Stroke_Value);
        __Left_Against_Medical_Advice = new Lazy<CqlValueSet>(this.Left_Against_Medical_Advice_Value);
        __Non_Elective_Inpatient = new Lazy<CqlValueSet>(this.Non_Elective_Inpatient_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __Patient_Expired = new Lazy<CqlValueSet>(this.Patient_Expired_Value);
        __Ticagrelor_Therapy = new Lazy<CqlValueSet>(this.Ticagrelor_Therapy_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Non_Elective_Inpatient_Encounter = new Lazy<IEnumerable<Encounter>>(this.Non_Elective_Inpatient_Encounter_Value);
        __All_Stroke_Encounter = new Lazy<IEnumerable<Encounter>>(this.All_Stroke_Encounter_Value);
        __Encounter_with_Principal_Diagnosis_and_Age = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Principal_Diagnosis_and_Age_Value);
        __Ischemic_Stroke_Encounter = new Lazy<IEnumerable<Encounter>>(this.Ischemic_Stroke_Encounter_Value);
        __Ischemic_Stroke_Encounters_with_Discharge_Disposition = new Lazy<IEnumerable<Encounter>>(this.Ischemic_Stroke_Encounters_with_Discharge_Disposition_Value);
        __Intervention_Comfort_Measures = new Lazy<IEnumerable<object>>(this.Intervention_Comfort_Measures_Value);
        __Comfort_Measures_during_Hospitalization = new Lazy<IEnumerable<Encounter>>(this.Comfort_Measures_during_Hospitalization_Value);
        __Encounter_with_Comfort_Measures_during_Hospitalization = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Comfort_Measures_during_Hospitalization_Value);
    }
    #region Dependencies

    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

    #endregion

    private CqlValueSet Comfort_Measures_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);

    [CqlDeclaration("Comfort Measures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45")]
    public CqlValueSet Comfort_Measures() => __Comfort_Measures.Value;

    private CqlValueSet Discharge_To_Acute_Care_Facility_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
    public CqlValueSet Discharge_To_Acute_Care_Facility() => __Discharge_To_Acute_Care_Facility.Value;

    private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => __Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

    private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care() => __Discharged_to_Home_for_Hospice_Care.Value;

    private CqlValueSet Emergency_Department_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Encounter_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Hemorrhagic_Stroke_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);

    [CqlDeclaration("Hemorrhagic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212")]
    public CqlValueSet Hemorrhagic_Stroke() => __Hemorrhagic_Stroke.Value;

    private CqlValueSet Ischemic_Stroke_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247")]
    public CqlValueSet Ischemic_Stroke() => __Ischemic_Stroke.Value;

    private CqlValueSet Left_Against_Medical_Advice_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
    public CqlValueSet Left_Against_Medical_Advice() => __Left_Against_Medical_Advice.Value;

    private CqlValueSet Non_Elective_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlDeclaration("Non-Elective Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
    public CqlValueSet Non_Elective_Inpatient() => __Non_Elective_Inpatient.Value;

    private CqlValueSet Observation_Services_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services() => __Observation_Services.Value;

    private CqlValueSet Patient_Expired_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
    public CqlValueSet Patient_Expired() => __Patient_Expired.Value;

    private CqlValueSet Ticagrelor_Therapy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39", null);

    [CqlDeclaration("Ticagrelor Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39")]
    public CqlValueSet Ticagrelor_Therapy() => __Ticagrelor_Therapy.Value;

    private CqlCode Birth_date_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return a_;
	}

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var b_ = a_.ConvertIntegerToDecimal(default);
		var d_ = a_.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, b_);
		var f_ = a_.ConvertIntegerToDecimal(default);
		var h_ = a_.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, f_);
		var j_ = a_.Interval(d_, h_, true, false);
		var k_ = context.ResolveParameter("TJCOverallFHIR-1.8.000", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_Value()
	{
		var a_ = this.Non_Elective_Inpatient();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		bool? d_(Encounter NonElectiveEncounter)
		{
			var g_ = NonElectiveEncounter.Period;
			var h_ = FHIRHelpers_4_0_001.ToInterval(g_);
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.LengthInDays(h_);
			var j_ = context.Operators;
			var k_ = j_.LessOrEqual(i_, (int?)120);
			var m_ = FHIRHelpers_4_0_001.ToInterval(g_);
			var o_ = j_.End(m_);
			var p_ = this.Measurement_Period();
			var r_ = j_.ElementInInterval<CqlDateTime>(o_, p_, "day");
			var t_ = j_.And(k_, r_);

			return t_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Encounter>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Non Elective Inpatient Encounter")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter() => __Non_Elective_Inpatient_Encounter.Value;

    private IEnumerable<Encounter> All_Stroke_Encounter_Value()
	{
		var a_ = this.Non_Elective_Inpatient_Encounter();
		bool? b_(Encounter NonElectiveEncounter)
		{
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(NonElectiveEncounter);
			var f_ = e_.Code;
			var g_ = FHIRHelpers_4_0_001.ToConcept(f_);
			var h_ = this.Hemorrhagic_Stroke();
			var i_ = context.Operators;
			var j_ = i_.ConceptInValueSet(g_, h_);
			var l_ = e_.Code;
			var m_ = FHIRHelpers_4_0_001.ToConcept(l_);
			var n_ = this.Ischemic_Stroke();
			var p_ = i_.ConceptInValueSet(m_, n_);
			var r_ = i_.Or(j_, p_);

			return r_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("All Stroke Encounter")]
    public IEnumerable<Encounter> All_Stroke_Encounter() => __All_Stroke_Encounter.Value;

    private IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age_Value()
	{
		var a_ = this.All_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter AllStrokeEncounter)
		{
			var e_ = context.DataRetriever;
			var f_ = e_.RetrieveByValueSet<Patient>(null, null);
			bool? g_(Patient BirthDate)
			{
				var m_ = this.Patient();
				var n_ = m_.BirthDateElement;
				var o_ = n_.Value;
				var p_ = context.Operators;
				var q_ = p_.ConvertStringToDateTime(o_);
				var r_ = AllStrokeEncounter.Period;
				var s_ = FHIRHelpers_4_0_001.ToInterval(r_);
				var u_ = p_.Start(s_);
				var w_ = p_.CalculateAgeAt(q_, u_, "year");
				var y_ = p_.GreaterOrEqual(w_, (int?)18);

				return y_;
			};
			var h_ = context.Operators;
			var i_ = h_.WhereOrNull<Patient>(f_, g_);
			Encounter j_(Patient BirthDate) => AllStrokeEncounter;
			var l_ = h_.SelectOrNull<Patient, Encounter>(i_, j_);

			return l_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Encounter with Principal Diagnosis and Age")]
    public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age() => __Encounter_with_Principal_Diagnosis_and_Age.Value;

    private IEnumerable<Encounter> Ischemic_Stroke_Encounter_Value()
	{
		var a_ = this.Encounter_with_Principal_Diagnosis_and_Age();
		bool? b_(Encounter EncounterWithAge)
		{
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(EncounterWithAge);
			var f_ = e_.Code;
			var g_ = FHIRHelpers_4_0_001.ToConcept(f_);
			var h_ = this.Ischemic_Stroke();
			var i_ = context.Operators;
			var j_ = i_.ConceptInValueSet(g_, h_);

			return j_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter() => __Ischemic_Stroke_Encounter.Value;

    private IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition_Value()
	{
		var a_ = this.Ischemic_Stroke_Encounter();
		bool? b_(Encounter IschemicStrokeEncounter)
		{
			var e_ = IschemicStrokeEncounter.Hospitalization;
			var f_ = e_.DischargeDisposition;
			var g_ = FHIRHelpers_4_0_001.ToConcept(f_);
			var h_ = this.Discharge_To_Acute_Care_Facility();
			var i_ = context.Operators;
			var j_ = i_.ConceptInValueSet(g_, h_);
			var l_ = e_.DischargeDisposition;
			var m_ = FHIRHelpers_4_0_001.ToConcept(l_);
			var n_ = this.Left_Against_Medical_Advice();
			var p_ = i_.ConceptInValueSet(m_, n_);
			var r_ = i_.Or(j_, p_);
			var t_ = e_.DischargeDisposition;
			var u_ = FHIRHelpers_4_0_001.ToConcept(t_);
			var v_ = this.Patient_Expired();
			var x_ = i_.ConceptInValueSet(u_, v_);
			var z_ = i_.Or(r_, x_);
			var ab_ = e_.DischargeDisposition;
			var ac_ = FHIRHelpers_4_0_001.ToConcept(ab_);
			var ad_ = this.Discharged_to_Home_for_Hospice_Care();
			var af_ = i_.ConceptInValueSet(ac_, ad_);
			var ah_ = i_.Or(z_, af_);
			var aj_ = e_.DischargeDisposition;
			var ak_ = FHIRHelpers_4_0_001.ToConcept(aj_);
			var al_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care();
			var an_ = i_.ConceptInValueSet(ak_, al_);
			var ap_ = i_.Or(ah_, an_);

			return ap_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition() => __Ischemic_Stroke_Encounters_with_Discharge_Disposition.Value;

    private IEnumerable<object> Intervention_Comfort_Measures_Value()
	{
		var a_ = this.Comfort_Measures();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<ServiceRequest>(a_, null);
		bool? d_(ServiceRequest P)
		{
			var o_ = P.IntentElement;
			var p_ = new CallStackEntry("ToString", null, null);
			var q_ = context.Deeper(p_);
			var r_ = q_.Operators;
			var s_ = r_.TypeConverter;
			var t_ = s_.Convert<string>(o_);
			var u_ = context.Operators;
			var v_ = u_.Equal(t_, "order");

			return v_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<ServiceRequest>(c_, d_);
		var i_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		bool? j_(Procedure InterventionPerformed)
		{
			var w_ = InterventionPerformed.StatusElement;
			var x_ = new CallStackEntry("ToString", null, null);
			var y_ = context.Deeper(x_);
			var z_ = y_.Operators;
			var aa_ = z_.TypeConverter;
			var ab_ = aa_.Convert<string>(w_);
			var ac_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var ad_ = context.Operators;
			var ae_ = ad_.InList<string>(ab_, (ac_ as IEnumerable<string>));

			return ae_;
		};
		var l_ = e_.WhereOrNull<Procedure>(i_, j_);
		var n_ = e_.ListUnion<object>((f_ as IEnumerable<object>), (l_ as IEnumerable<object>));

		return n_;
	}

    [CqlDeclaration("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures() => __Intervention_Comfort_Measures.Value;

    private IEnumerable<Encounter> Comfort_Measures_during_Hospitalization_Value()
	{
		var a_ = this.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var e_ = this.Intervention_Comfort_Measures();
			bool? f_(object ComfortMeasure)
			{
				var l_ = context.Operators;
				var m_ = l_.LateBoundProperty<object>(ComfortMeasure, "performed");
				var o_ = l_.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				var p_ = ((m_ as FhirDateTime) ?? o_);
				var q_ = FHIRHelpers_4_0_001.ToDateTime(p_);
				var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(IschemicStrokeEncounter);
				var t_ = l_.ElementInInterval<CqlDateTime>(q_, r_, null);

				return t_;
			};
			var g_ = context.Operators;
			var h_ = g_.WhereOrNull<object>(e_, f_);
			Encounter i_(object ComfortMeasure) => IschemicStrokeEncounter;
			var k_ = g_.SelectOrNull<object, Encounter>(h_, i_);

			return k_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization() => __Comfort_Measures_during_Hospitalization.Value;

    private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_Value()
	{
		var a_ = this.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var e_ = this.Intervention_Comfort_Measures();
			bool? f_(object ComfortMeasure)
			{
				var l_ = context.Operators;
				var m_ = l_.LateBoundProperty<object>(ComfortMeasure, "performed");
				var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);
				var p_ = l_.Start(n_);
				var r_ = l_.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				var s_ = FHIRHelpers_4_0_001.ToDateTime(r_);
				var t_ = (p_ ?? s_);
				var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(IschemicStrokeEncounter);
				var w_ = l_.ElementInInterval<CqlDateTime>(t_, u_, null);

				return w_;
			};
			var g_ = context.Operators;
			var h_ = g_.WhereOrNull<object>(e_, f_);
			Encounter i_(object ComfortMeasure) => IschemicStrokeEncounter;
			var k_ = g_.SelectOrNull<object, Encounter>(h_, i_);

			return k_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization() => __Encounter_with_Comfort_Measures_during_Hospitalization.Value;

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlDateTime StartValue)
	{
		var a_ = context.Operators;
		var b_ = a_.DateFrom(StartValue);
		var d_ = a_.Quantity(1m, "day");
		var f_ = a_.Add(StartValue, d_);
		var h_ = a_.DateFrom(f_);
		var j_ = a_.Interval(b_, h_, true, true);

		return j_;
	}


}