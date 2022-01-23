namespace metodos_de_extensao
{
    public static class ExtensionMethods
    {
        public static string UppercaseFirstLetter(this string value)
        {
            if(value.Length >0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }
    }
}
