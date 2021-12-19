import { Component, OnInit } from '@angular/core';
import { UploadService } from 'src/app/services/upload.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-import-data',
  templateUrl: './import-data.component.html',
  styleUrls: ['./import-data.component.css']
})
export class ImportDataComponent implements OnInit {
  selectedFile:File = null;
  constructor(private service:UploadService,private toastr: ToastrService) { }

  ngOnInit(): void {
      
  }
  onFileSelected(event){
    console.log(event);
    this.selectedFile=event.target.files[0];
  }
  onUpload(){
    this.service.Upload(this.selectedFile).subscribe(i=>{
      console.log(i);
      this.toastr.success("Uploaded Successfully.")
    });
  }

}