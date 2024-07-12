

const FormatNumber= (item) => {
    if (item != null )
    {
        var value = Number.parseInt(item.toString().replaceAll(".",""))
        return value
    }
    return item;

}

const FormatNumberShow= (value) => {
    let val = (value/1).toFixed(2).replace('.', ',')
    return value.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ".")

}
export const formatNumber = {FormatNumber , FormatNumberShow};

