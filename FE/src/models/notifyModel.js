// const addMessage = (item) => {
//     return {
//         resultString: item.resultString,
//         resultCode: item.resultCode
//     }
// }
//
// export const notifyModel = {addMessage};

const addMessage = (item, show, code) => {
    return {
        message: item.message,
        code: item.code
    }
}

export const notifyModel = {addMessage};
