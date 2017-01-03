** Developed by: Pankaj Mohan
** Operating system used: windows 8, 64 bit
** Editor used: Visual studio 2015
** .NET Framework: 4.5.2

********** Design **********

1. Secret function returns the same number passed to it as return value.
2. Program works only for integer inputs.
3. Algorith used to generate prime numbers is segmented sieve.
4. Programs creates a file with segment ranges required by segmented sieve algorithm written to it.

********** How to run **********

1. Open project in visual studio 2015.
2. Build the project, this will generate .exe file.
3. Launch Command prompt and navigate to the folder containing .exe file generated in step 2.
4. Enter: FunctionAdditiveChecker <parameter> 

OR

1. Navigate to C:\SFAdditiveChecker-master\SFAdditiveChecker-master\FunctionAdditiveChecker\FunctionAdditiveChecker\bin\Debug
Assuming project is downloaded to C drive

2. Enter FunctionAdditiveChecker <parameter>
********** Sample Run **********
Input:
FunctionAdditiveChecker 158

Output:
Input to secret function is: 158
Output of secret function is: 158
Number of primes generated: 37
Secret function is additive.
Press any key to exit.
