Vue.component("my-page", {
    watch: {
        pageIndex: function () {
            return this.$emit("change", this.pageIndex);
        }
    },
    model: {
        prop: "pageIndex",
        event: "change"
    },
    computed: {
        count: function () {
            return this.total % this.size == 0 ? parseInt(this.total / this.size) : parseInt((this.total / this.size) + 1);
        },//总页数    
        ToggleCount: function () {
            return this.count % this.displayElementCountOfA == 0 ? parseInt(this.count / this.displayElementCountOfA) : parseInt((this.count / this.displayElementCountOfA) + 1);
        },//如果当前页为最后一个标签，就进行切换一次,对分页的数据进行更新一次
        currentFirstNumber: function () {
            return this.currentToggleCount * this.displayElementCountOfA;
        },//当前第一个分页标签中第一个字母
        currentLastNumber: function () {
            return this.currentToggleCount < this.ToggleCount - 1 ? (this.currentToggleCount + 1) * this.displayElementCountOfA : this.count;
        }//当前分页标签中最后一个字母
    },
    props: {
        "size": { type: Number, default: 0 },//大小
        "total": { type: Number, default: 0 },//总条数
        "resource": { type: Array, default: [] },//数据
        "ishaveopration": { type: Boolean, default: false },//是否出现操作符
        "ishaveadd": { type: Boolean, default: false },//是否出现添加按钮
        "ishavedelete": { type: Boolean, default: false },//是否出现删除按钮
        "ishaveupdate": { type: Boolean, default: false },//是否出现修改按钮
        "ishavefindone": { type: Boolean, default: false },//是否出现单值查询按钮
        "addurl": { type: String, default: "#" },//添加的路径
        "deleteurl": { type: String, default: "#" },//删除的路径
        "updateurl": { type: String, default: "#" },//修改的路劲
        "findurl": { type: String, default: "#" },//单值查询的路劲
        "paremeter": { type: String, default: "#" }//增删改查的参数(id)
       //"currentpagename": { type: String,default:"#" } //当前页面的相对路劲(Action或页面的地址)
    },
    data: function () {
        return {
            pageIndex: 1,
            displayElementCountOfA: 5,//显示分页中超链接标签的数量
            currentToggleCount: 0,//当前切换的次数
            isDisplayData: true, //是否显示数据
            isExecuteNextCode: true //是否执行下一行代码
        }
    },
    mounted: function () {
        if (this.resource.isHaveData) {
            if (this.ishaveopration && (this.ishavedelete || this.ishavefindone || this.ishaveupdate)) {
                if (this.paremeter == "#" || this.paremeter == "" || this.paremeter == null) {
                    this.isDisplayData = false;
                    throw "如需通过该组件生成表格，并且需要进行操作，请为当前组件添加该表的主键列名或其他列名";
                }
            }
        }
    },
    methods: {
        goPage: function (x, num) {//通过传入的数字来判断点击的下拉框还是分页中的标签
            this.pageIndex = x;
            if (num != 0) {
                this.currentToggleCount = this.pageIndex % this.displayElementCountOfA == 0 ? parseInt(this.pageIndex / this.displayElementCountOfA) : parseInt((this.pageIndex / this.displayElementCountOfA) + 1);
                this.currentToggleCount--;//因为默认为0，如果为1则可省略此步  
            }
        },
        toggleIndex: function (num) { //切换下标 0则为上一页 1则为下一页
            if (num == 0) {
                if (this.pageIndex == (this.currentFirstNumber + 1) && this.currentToggleCount > 0) {//如果当前的页面等于第一个数字，点击上一页就说明需要切换了，同时切换的次数要大于0
                    this.currentToggleCount--;
                    this.currentLastNumber = (this.currentToggleCount - 1) * this.displayElementCountOfA; //更新数据,更新分页中标签中末尾的数字
                }
                this.pageIndex = this.pageIndex > 1 ? this.pageIndex - 1 : 1;
            }
            else if (num == 1) {
                if (this.pageIndex != this.count) { //因为切换次数默认为0，如果没有此步骤，最后没有数据的时候将会多切换一次
                    if (this.pageIndex == this.currentLastNumber && this.currentToggleCount < this.ToggleCount) {//如果当前的页面等于最后的数字，点击下一页就说明需要切换了，同时当前切换的次数小于总共能切换的次数
                        this.currentToggleCount++;
                        this.currentLastNumber = (this.currentToggleCount + 1) * this.displayElementCountOfA; //更新数据,更新分页中标签中末尾的数字
                    }
                    this.pageIndex = this.pageIndex < this.count ? this.pageIndex + 1 : this.count;
                }
            }
        },
        ModifyData: function (id, url, callback) {
            if (id < 0 || id == "" || id == null) {
                throw "无法得到id参数值";
                this.isExecuteNextCode = false;
            }            
            if (url == "#" || url == null || url == "") {
                throw "url缺少参数,请进行赋相应的值";
                this.isExecuteNextCode = false;
            }
            if (this.isExecuteNextCode) {
                this.$http.delete(url + id).then(d => { callback != null ? callback(d.data) : null; });        
            }   
        },
        del: function (id, index) {
            var obj = this;
            this.ModifyData(id, this.deleteurl, function (d) {
                if (d > 0) {
                    obj.resource.ls.splice(index, 1);
                }
            })
        },
        edit: function (id) {
            location.href = this.updateurl + id;
        },
        find: function (id) {
            location.href = this.findurl + id;
        }
    },
    template: '<ul class="pagination">\
                        <li v-if="resource!=null && isDisplayData">\
                            <table border="1" class="table table-bordered table-striped">\
                                        <thead >\
                                            <tr>\
                                                <td v-for= "(objhead,indexhead) in resource.head" > {{ objhead.title }}</td > <td v-if="ishaveopration">Operation</td>\
                                            </tr >\
                                        </thead >\
                                        <tbody>\
                                            <tr v-for="(objdata,indexdata) in resource.ls">\
                                                <td v-if="objhead2.formatter==null"  v-for= "(objhead2,indexhead2) in resource.head" > {{objdata[objhead2.key]}}</td >\
                                                <td v-else>{{objhead2.formatter(objdata[objhead2.key])}}</td> \
                                                <td v-if= "ishaveopration" >\
                                                    <a :href="addurl" v-if="ishaveadd" class="btn btn-default btn-xs" >Add</a >\
                                                    <a href="#" @click="del(objdata[paremeter],indexdata)"  v-if="ishavedelete" class="btn btn-danger btn-xs" >Delete</a >\
                                                    <a href="#" @click="edit(objdata[paremeter])" v-if="ishaveupdate" class="btn btn-primary btn-xs" >Modify</a >\
                                                    <a href="#"  @click="find(objdata[paremeter])"v-if="ishavefindone" class="btn btn-success btn-xs" >Find</a >\
                                                </td >\
                                            </tr >\
                                        </tbody >\
                            </table>\
                        </li ><br v-if="resource==null"/>\
                        <li v-if="isDisplayData">\
                            <a href = "#" aria-label="Previous"  @click="toggleIndex(0)">\
                                <span aria-hidden="true">&laquo;</span>\
                             </a>\
                        </li >\
                        <li v-for="(x,index) in currentLastNumber" :class="{active:x==pageIndex}" v-if="isDisplayData"><a href="#" @click="goPage(x,0)" v-if="x>currentFirstNumber && x<=currentLastNumber">{{x}}</a></li>\
                        <li v-if="isDisplayData">\
                            <a href="#" @click="toggleIndex(1)" aria-label="Next">\
                                <span aria-hidden="true">&raquo;</span>\
                            </a>\
                            <a href="#" aria-label="Next">\
                                <span aria-hidden="true">第{{pageIndex}}页/共{{count}}页   |   共{{total}}条</span>\
                            </a>\
                     </li>\
                    <li v-if="isDisplayData">\
                            <select @change="goPage($event.target.value,1)" v-model="pageIndex">\
                                <option v-for="x in count" :value="x">{{x}}</option>\
                            </select>\
                    </li>\
       </ul >'
})