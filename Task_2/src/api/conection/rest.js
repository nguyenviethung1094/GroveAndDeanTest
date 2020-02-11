
export const getData = (url) => {
        const data = fetch(url).then(res => res.json())
        return data
}
