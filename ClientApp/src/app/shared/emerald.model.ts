export interface Emerald {
  id:number
  title:string
  quote:string
  author:string
  goal:string
  emeraldImageUrl:string
  resources:Resource[]
  notes?:string[]
}

interface Resource {
  name:string
  link?:string
}