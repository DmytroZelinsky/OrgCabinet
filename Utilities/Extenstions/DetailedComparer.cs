using EntityLayer.Entities;
using System.Reflection;

namespace Utilities.Extenstions
{
	public static class DetailedComparer
	{
        public static List<Variance> DetailedCompare<T>(this T val1, T val2)
        {
			List<Variance> variances = new List<Variance>();
			FieldInfo[] fi = val1.GetType().GetFields(BindingFlags.Instance |
					   BindingFlags.Static |
					   BindingFlags.NonPublic |
					   BindingFlags.Public);
			foreach (FieldInfo f in fi)
			{
				Variance v = new Variance();

				int pFrom = f.Name.IndexOf("<") + "<".Length;
				int pTo = f.Name.LastIndexOf(">");

				v.Prop = f.Name.Substring(pFrom, pTo - pFrom);
				v.valA = f.GetValue(val1);
				v.valB = f.GetValue(val2);
				if (!Equals(v.valA, v.valB))
					variances.Add(v);
			}
			return variances;
		}
	}
}
