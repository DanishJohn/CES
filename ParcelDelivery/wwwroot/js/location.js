function convertToDataTableFrom(responseData) {
    var cityArr = [];
    for (var i = 0; i < responseData.length; i++) {
        var singleArr = [responseData[i].id, responseData[i].name, responseData[i].code, null];
        cityArr.push(singleArr);
    }
    return cityArr;
}