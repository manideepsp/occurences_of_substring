***Testcases:***
> 1. Description: The strings S1 and S2 can contain uppercase and lowercase letters, as well as special characters and digits. "Positive"
> 2. Description: The search for the substring should be case-sensitive. "Positive".
> 3. Description: Verify that S1>=S2 "Negative"
>	i/p:	s1 `bhj`
>>				s2 `bhddcjcb`
>	Expected output:	Throws exception with error message: "subString length should be smaller than originalString"
>						Prints error message to console for user: "Wrong input"
>		o/p:	ArgumentException"subString length should be smaller than originalString"
>>				Wrong input
> 4. Verify that both S1 and S2 are not null "Negative"
>		i/p:	