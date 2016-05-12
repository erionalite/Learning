define(function() {
    var printErrorMessage = function(message) {
        console.log("%c" + message,"color:red");
    }
    return {
        log : printErrorMessage
    }
});