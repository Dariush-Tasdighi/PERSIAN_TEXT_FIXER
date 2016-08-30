namespace Dtx
{
	internal static class Utility
	{
		static Utility()
		{
		}

		internal const string VERSION = "۲.۰.۱";

		/// <summary>
		/// Version: 2.0.1
		/// Update Date: 1395/01/24
		/// Developer: Mr. Dariush Tasdighi
		/// </summary>
		internal static string FixPersianText(string source, bool convertDigits)
		{
			if (string.IsNullOrEmpty(source))
			{
				return (string.Empty);
			}

			source = source.Trim();
			if (source == string.Empty)
			{
				return (string.Empty);
			}

			while (source.Contains("  "))
			{
				source = source.Replace("  ", " ");
			}

			source = source.Replace("{ ", "{");
			source = source.Replace("( ", "(");
			source = source.Replace("[ ", "[");

			source = source.Replace(" }", "}");
			source = source.Replace(" )", ")");
			source = source.Replace(" ]", "]");

			source = source.Replace(" !", "!");
			source = source.Replace(" ?", "?");
			source = source.Replace(" ؟", "؟");

			source = source.Replace(" .", ".");
			source = source.Replace(" :", ":");

			source = source.Replace(" ;", ";");
			source = source.Replace(" ؛", "؛");

			source = source.Replace(" ,", ",");
			source = source.Replace(" ،", "،");

			string strTarget = string.Empty;

			char? chrNext;
			char chrCurrent;

			int intIndex = 0;
			int intNextIndex = intIndex + 1;

			while (intIndex <= source.Length - 1)
			{
				chrCurrent = source[intIndex];

				if (intIndex == source.Length - 1)
				{
					chrNext = null;
				}
				else
				{
					chrNext = source[intIndex + 1];
				}

				switch (chrCurrent)
				{
					case '{':
					case '(':
					case '[':
					{
						if ((intIndex == 0) ||
							(strTarget.Substring(strTarget.Length - 1) == " ") ||
							(strTarget.Substring(strTarget.Length - 1) == "\n") ||
							(strTarget.Substring(strTarget.Length - 1) == "\r"))
						{
							strTarget += chrCurrent.ToString();
						}
						else
						{
							strTarget += " " + chrCurrent.ToString();
						}

						break;
					}

					case 'ی':
					case 'ي':
					//case 'ئ':
					{
						strTarget += "ی";

						break;
					}

					case 'ك':
					case 'ک':
					{
						strTarget += "ک";

						break;
					}

					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
					{
						if (convertDigits)
						{
							switch (chrCurrent)
							{
								case '0':
								{
									strTarget += '۰';
									break;
								}

								case '1':
								{
									strTarget += '۱';
									break;
								}

								case '2':
								{
									strTarget += '۲';
									break;
								}

								case '3':
								{
									strTarget += '۳';
									break;
								}

								case '4':
								{
									strTarget += '۴';
									break;
								}

								case '5':
								{
									strTarget += '۵';
									break;
								}

								case '6':
								{
									strTarget += '۶';
									break;
								}

								case '7':
								{
									strTarget += '۷';
									break;
								}

								case '8':
								{
									strTarget += '۸';
									break;
								}

								case '9':
								{
									strTarget += '۹';
									break;
								}
							}
						}
						else
						{
							strTarget += chrCurrent.ToString();
						}

						break;
					}

					case '}':
					case ')':
					case ']':
					case '!':
					case '?':
					case '؟':
					case '.':
					case ':':
					case ';':
					case '؛':
					case ',':
					case '،':
					{
						if ((chrNext == ' ') || (chrNext == '\n') || (chrNext == '\r'))
						{
							strTarget += chrCurrent.ToString();
						}
						else
						{
							strTarget += chrCurrent.ToString() + " ";
						}

						break;
					}

					default:
					{
						strTarget += chrCurrent.ToString();

						break;
					}
				}

				intIndex++;
			}

			strTarget = strTarget.Replace("می ", "می‌");
			strTarget = strTarget.Replace("بی ", "بی‌");
			strTarget = strTarget.Replace(" ها", "‌ها");

			return (strTarget);
		}
	}
}
