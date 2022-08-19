//declaring var to store header text
var text = document.getElementById("hello_world");

/* function takes the whole string and position of current letter,
 wraps that letter with span to change color */
function changeLetter(textToChange, pos) {
    //if position is same as length, this is the end so return plain word
    if (textToChange.length == pos) return textToChange;

    //split text at letter and insert span around letter
    return textToChange.substring(0, pos)
        + '<span style="color:blue;">' + textToChange[pos] + '</span>'
        + textToChange.substring(pos+1);
}

//function to be called onclick to trigger animation
function wave(text) {
    //copy of text
    var letters = text.innerHTML;

    //for each letter, call function to change color after 1s delay
    //loop 1 extra time to remove color on last loop
    for (var i = 0; i <= text.innerHTML.length; i++) {
        (function (i) {
            setTimeout(function () {
                text.innerHTML = changeLetter(letters, i);
            }, 1000 * i);
        })(i);
    }
}