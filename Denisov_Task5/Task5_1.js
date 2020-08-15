var drawCats = function (howManyTimes)
{
    for (var i = 0; i < howManyTimes; i++)
    {
        console.log(i+"=^.^=")
    }
}

var DeleteRepeats = function (targetString)
{
    var resultString = "";

    var repeats = "";

    var wordsList = targetString.split(" ")

    for(let i = 0; i < wordsList.length; i++){

        let pass = "";

        for(let j = 0; j < wordsList[i].length; j++){

            if(pass.includes(wordsList[i][j])){
                repeats = repeats + wordsList[i][j];
            }
            pass = pass + wordsList[i][j]
        }

    }

    for(let i = 0; i < targetString.length; i++){
        if(!repeats.includes(targetString[i])){
            resultString = resultString + targetString[i];
        }
    }

    console.log(resultString)   
}

DeleteRepeats("У попа, была собака")