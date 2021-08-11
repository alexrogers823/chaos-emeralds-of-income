import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { tap } from "rxjs/operators";
import { Note } from "../components/common/note/note.model";

@Injectable()
export class NotesService {
  constructor(private http: HttpClient) {}
  
  _baseUrl:string = "api/Notes";

  // get notes 
  getNotesForIncome(incomeId:number) {
    return this.http.get<Note[]>(this._baseUrl)
      .pipe(
        tap(obj => console.log("getting notes...", obj))
      )
  }

  // post notes
  addNote(noteObj:Note) {
    // return this.http.post<Note[]> 
  }

  // update notes
}