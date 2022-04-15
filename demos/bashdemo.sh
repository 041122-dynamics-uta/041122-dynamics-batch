#!/bin/bash

#to quit a running process, use 'ctrl + c'
# to comment a line, place the cursor anywhere on the line and type 'ctrl + /'
# to comment multiple lines, highlight any part of all the lines and type 'ctrl + /'

#output
echo Welcome to the bash demo! Give me your name.

#input
# read input

#create and instantiation of a variable
myVar=Arely


#string interpolation
# echo Your name is $input. #you don't need the {} for interpolation in bash
# echo Your name is $myVar.

#get some numbers
echo Give me the first number
read num1
# echo $num1

echo Give me the second number
read num2
echo $num2

#adding
expr $num1 + $num2
echo The sum is $(( num1 + num2 )) # with interpolation

#subtracting
expr $num1 - $num2
echo The difference is $(( num1 - num2 )) # with interpolation

#multiplying
expr $num1 \* $num2 # the '\' is an "escape' character.n 
                    # It will take out the default meaning 
                    # of a symbol and allow it to be either 
                    # ignored or to take on it's traditional 
                    # meaning
echo The product is $(( num1 * num2 )) # with expression interpolation

#this is escaping the escapre character You'll see this on occasion.
#this\\is\\the\\path\\to\\the\\file

#Dividing
expr $num1 / $num2
echo The quotient is $(( num1 / num2 )) # with interpolation
# 5/4 = 1 in a computer becaue dividing integers leaves the 
# whole number and truncates any remainder.

# modulo
expr $num1 % $num2
echo The modulus is $(( num1 % num2 )) # with interpolation
# use modulo to get the remainder as a numbers

#loops. control flow statement
if [ $num1 -gt $num2 ] # if this is true
  then
  echo $num1 is greater than $num2. #to this
elif [ $num1 -lt $num2 ] #else.... if this is true...
  then
  echo $num1 is less than $num2 #do this
else #if neither of the above are true
  echo The numbers are equal. #do this.
fi

# a while loop runs until a condition is met.
while [ $num1 -lt 10 ]
do
  # echo this is an infinite loop
  # (( num1++ )) # increment the value of the number by 1.
  num1=$(( num1 + 1 ))
  echo The value of num1 is $num1.
done
  # echo WHILE The value of num1 is $num1. # the value of the variable 

# num1=21
#until loop is known far and wide as a do/while loops
until [ $num1 -gt 20 ]
do
  (( num1++ ))
  echo UNTIL The value of num1 is $num1.
done

# for loop loop with an interator until the condition is meaning
# this is a range for loop
for x in {0..10}
do
  echo The value of he iterator is $x
done

for x in {10..0}
do
  echo The value of he iterator is $x
done

#for loop that you use the variables with
for (( i=$num1; i>1; i-- ))
do
  echo The value of i is $i.
done
echo "the value of i is $i outside the for loop."

#the 'break' keyword breaks you out of a loop 
# immediately without finishing the cycles.
for val in {10..15}
do
  echo the value is ${val} #interpolation
  if [ $val -eq 12 ]
  then
    echo breaking now!!
    break
  fi
done

#the 'continue' keyword jumps out of 
# the current cycle and starts the next yccle immediately...
for val in {10..15}
do
  echo the value is ${val} #interpolation

  if [ $val -eq 12 ]
  then
    echo Do you want to subtract 2 from val?
    read input
    # input.toupper() #will conver Yes to YES.. yEs to YES
    if [ $input == "yes" || $input == "Yes"  ]
    then
      val=$(( val - 2 ))
      echo the value of val is $val.
    fi

    if [ $val -eq 7 ]
    then
      echo continuing now!!
      continue
    fi
  fi
  echo end of looooop....
done

#functions! A function is a encapsulated series of 
# steps that will be executed 
# when you call the function.
# to create a function
# in bash, the functions MUST be declared above any place where it is called.
multiply () {
  echo This is the mutiply function.
  expr $(( num1 * num2 ))
}

echo Would you like to multiple num1 and num2?
read input2
if [ $input2 == "yes" ]
then
  multiply
fi

#Challenge:
# sort this array least to greatest.
~



#parse a string. Then type define (cast) to a integer
#
#
#
#





