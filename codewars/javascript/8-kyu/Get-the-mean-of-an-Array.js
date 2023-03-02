/*
It's the academic year's end, fateful moment of your school report. The averages must be calculated. All the students come to you and entreat you to calculate their average for them. Easy ! You just need to write a script.

Return the average of the given array rounded down to its nearest integer.

The array will never be empty.
*/

function getAverage(marks) {
  // a place to store the sum, initialized to zero
  let sum = 0;
  // iterate over the marks
  for (let i = 0; i < marks.length; i += 1) {
    // add the current mark to the sum
    const mark = marks[i];
    sum += mark;
  }

  // return the sum divided by the number of marks
  return Math.floor(sum / marks.length);
}

/* OTHER SOLUTIONS:

Using forEach instead of a for loop: 

function getAverage(marks) {
  // a place to store the sum, initialized to zero
  let sum = 0;
  // iterate over the marks
  marks.forEach(mark) =>
  {
    sum = sum + mark;
  }

  // return the sum divided by the number of marks
  return Math.floor(sum / marks.length);
}
*/
