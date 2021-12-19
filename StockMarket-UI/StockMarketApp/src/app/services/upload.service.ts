// import { Injectable } from '@angular/core';

// @Injectable({
//   providedIn: 'root'
// })
// export class UploadService {

//   constructor() { }
// }

import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';

const Requestheaders={headers:new HttpHeaders({
  'Content-Type': 'application/json',
  'Authorization': "Bearer "+localStorage.getItem('token')
})}

@Injectable({
  providedIn: 'root'
})
export class UploadService {
  path=environment.upload_url;
  constructor(private http:HttpClient) { }

  public Upload(selectedFile: File) {
    const fd=new FormData();
    fd.append('image',selectedFile,selectedFile.name);
    console.log("formfa0"+fd);
    
    return this.http.post(this.path+"UploadData", fd,Requestheaders);
  }
}