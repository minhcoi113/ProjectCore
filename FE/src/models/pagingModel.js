const toJson = (item) => {
    return {
        currentPage: item.currentPage,
        totalPages: item.totalPages,
        totalCount: item.totalCount,
        pageSize: item.pageSize,
        hasPrevious: item.hasPrevious,
        hasNext : item.hasNext
    }
}

const fromJson = (item) => {
    return {
        currentPage: item.currentPage,
        totalPages: item.totalPages,
        totalCount: item.totalCount,
        pageSize: item.pageSize,
        hasPrevious: item.hasPrevious,
        hasNext : item.hasNext,
        maxVisibleButtons: item.totalPages <= 5 ? item.totalPages: 5
    }
}

const baseJson = () => {
    return {
        currentPage: 1,
        totalPages: 0,
        totalCount:0,
        pageSize: 10,
        hasPrevious: false,
        hasNext :false,
        maxVisibleButtons: 5
    }
}


export const pagingModel = {
    toJson, fromJson, baseJson
}