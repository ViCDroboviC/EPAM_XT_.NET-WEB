var Calculate = function(expression){
    let numbers = expression.split(/[+/*-]/);
    let actions = expression.split('').filter(item => item.match(/[+/*-]/))
    
    result = numbers[0];
    for(let i = 0; i < actions.length; i++){
        switch(actions[i]){
            case "+":
                result = +result + +numbers[i+1]
                break
            case "-":
                result = result - numbers[i+1]
                break
            case "*":
                 result = result * numbers[i+1]
                break
            case "/":
                result = result / numbers[i+1]
                break
        }
    }
    console.log(result);
}

Calculate("5.5+6-7*2/2")