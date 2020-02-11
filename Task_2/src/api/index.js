import { getBaseUrl } from './config'
import { getData } from './conection/rest'

export const getAllUser = () => {
    const url = getBaseUrl() + 'users'
    const data = getData(url)
    return data
}