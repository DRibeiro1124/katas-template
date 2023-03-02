function booleanToString(bool) {
  let result;
  if (bool) {
    result = "true";
  } else {
    result = "false";
  }
  return result;
}

/* OTHER SOLUTIONS:

function booleanToString(b){
  return b.toString();
}
-----------------------------------------------------

function booleanToString(b){
  return b ? 'true' : 'false';
}
-----------------------------------------------------

const booleanToString = b => b ? 'true' : 'false';

-----------------------------------------------------