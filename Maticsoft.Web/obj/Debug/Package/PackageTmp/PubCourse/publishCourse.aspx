﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PubCourse/PubBasic.Master" AutoEventWireup="true" CodeBehind="publishCourse.aspx.cs" Inherits="Maticsoft.Web.PubCourse.publishCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <input type="hidden" id="hfCourseID" value="" runat="server">
<input type="hidden" id="pageInfo" value="5" />
<!-- start main -->
<div class="main">

<!-- start input6 -->
<div class="input6 border">
<div class="bg01">
<div class="bg02">
<div class="bg03">
<div class="bg_r"></div>
<div class="bg_l"></div>
<div class="con">

<div class="nav"><a href="">我要教</a> > <strong>公开课程</strong> > <strong>签署协议发布</strong></div>
<h2>签署协议发布</h2>
<div class="padding">
	<div class="agreement">
						<div class="agree" style="margin-top:-25px;">
                            <div  class="agrCenter" style="height:480px;overflow-y:scroll;border:1px solid #7F9DB9; padding:8px 15px;width:640px;margin-left:-10px;">
                            <h3 align="center">淘老师合作协议</h3>
                                <p align="center">本协议由您与求知创想教育咨询（北京）有限公司共同缔结，本协议具有合同效力。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;本协议中协议双方合称协议方，求知创想教育咨询（北京）有限公司在协议中亦称为"我公司"。本协议中"我公司平台"指由求知创想教育咨询（北京）有限公司运营的网络平台，包括域名为tlaoshi.com的淘老师网等。</p>
                                
								<h3>一、协议内容及签署</h3>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;1.本协议内容包括协议正文及所有我公司已经发布的或将来可能发布的各类规则。所有规则为本协议不可分割的组成部分，与协议正文具有同等法律效力。除另行明确声明外，任何我公司及其关联公司提供的服务（以下称为我公司平台服务）均受本协议约束。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;2.您应当在使用我公司平台服务之前认真阅读全部协议内容，对于协议中以加粗字体显示的内容，您应重点阅读。如您对协议有任何疑问，应向我公司咨询。但无论您事实上是否在使用我公司平台服务之前认真阅读了本协议内容，只要您使用我公司平台服务，则本协议即对您产生约束，届时您不应以未阅读本协议的内容或者未获得我公司对您问询的解答等理由，主张本协议无效，或要求撤销本协议。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;3.您承诺接受并遵守本协议的约定。如果您不同意本协议的约定，您应立即停止注册程序或停止使用我公司平台服务。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;4.我公司有权根据需要不时地制订、修改本协议及/或各类规则，并以网站公示的方式进行公告，不再单独通知您。变更后的协议和规则一经在网站公布后，立即自动生效。如您不同意相关变更，应当立即停止使用我公司平台服务。您继续使用我公司平台服务的，即表示您接受经修订的协议和规则。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;5.您受本协议约束的同时，也同时受您已经签署的《淘老师注册协议》的约束。</p>
                                
								<h3>二、 发布课程</h3>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;您确认：</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;1.您在一定的特定领域内有一定的专长，并按照我公司提供的模板和格式自主创作视频和音频作品。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;2.您必须接受我公司的实名认证，保证其提供的资质和履历的真实性和有效性。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;3.您在不与本合作协议相冲突的前提下，自主决定创作视频和音频作品的题材、内容、数量、时间等，但是您创作的视频和音频作品必须经过我公司的审核后，才能发布在我公司提供的互联网服务器上。我公司同时有权对您提供视频和音频作品做技术处理（包括加密处理、增加片头片尾等）。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;4.您创作的视频和音频作品，版权均属于您所有。但是未经我公司同意您不得将其创作的视频和音频作品和任何第三方进行任何形式的合作。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;5.您提供的视频和音频作品，不得包含反动、迷信、色情、暴力等不良内容，不得侵犯第三方的知识产权权利，造成侵权从而导致的任何后果由您完全负责，我公司不承担因此而产生的任何责任。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;6.您在与我公司协商一致的情况下为其视频和音频作品定价，不得免费发布。</p>

								<h3>三、 收入分配制度</h3>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;1.广告收入：视频和音频中插播的广告业务若是您获得的，则您享有80%的收入，我公司享有20%的收入。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;2.视频和音频购买收入：由于视频和音频是付费的，在客户购买付费完成后，您享有70%的收入，我公司享有30%的收入。在您提供的视频和音频被购买收费在一个月内达到1万元以上的，下个月的分配方式变更为您享有80%的收入，我公司享有20%的收入。若当月未能保持1万元的收费，则下个月变更回您享有70%的收入，我公司享有30%的收入。</p>

								<h3>四、 特别授权</h3>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;您完全理解并不可撤销地授予我公司及其关联公司下列权利：</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>1.一旦您向我公司及（或）其关联公司，作出任何形式的承诺，且相关公司已确认您违反了该承诺，则我公司有权立即按您的承诺或协议约定的方式对您的账户采取限制措施，包括中止或终止向您提供服务，并公示相关公司确认的您的违约情况。您了解并同意，我公司无须就相关确认与您核对事实，或另行征得您的同意，且我公司无须就此限制措施或公示行为向您承担任何的责任。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>2.一旦您违反本协议，或与我公司签订的其他协议的约定，我公司有权以任何方式通知我公司关联公司，要求其对您的权益采取限制措施，包括但不限于将您账户内的款项支付给我公司指定的对象，要求关联公司中止、终止对您提供部分或全部服务，且在其经营或实际控制的任何网站公示您的违约情况。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>3.对于您提供的资料及数据信息，您授予我公司及其关联公司独家的、全球通用的、永久的、免费的许可使用权利 (并有权在多个层面对该权利进行再授权)。此外，我公司及其关联公司有权(全部或部份地) 使用、复制、修订、改写、发布、翻译、分发、执行和展示您的全部资料数据（包括但不限于注册资料、交易行为数据及全部展示于我公司平台的各类信息）或制作其派生作品，并以现在已知或日后开发的任何形式、媒体或技术，将上述信息纳入其它作品内。 </b></p>
                                
								<h3>五、责任范围和责任限制</h3>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>1.我公司负责按"现状"和"可得到"的状态向您提供我公司平台服务。但我公司对我公司平台服务不作任何明示或暗示的保证，包括但不限于我公司平台服务的适用性、没有错误或疏漏、持续性、准确性、可靠性、适用于某一特定用途。同时，我公司也不对我公司平台服务所涉及的技术及信息的有效性、准确性、正确性、可靠性、质量、稳定、完整和及时性作出任何承诺和保证。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>2.您了解我公司平台上的信息系用户自行发布，且可能存在风险和瑕疵。我公司平台仅作为交易地点。我公司平台仅作为您获取物品或服务信息、物色交易对象、就物品和/或服务的交易进行协商及开展交易的场所，但我公司无法控制交易所涉及的物品的质量、安全或合法性，商贸信息的真实性或准确性，以及交易各方履行其在贸易协议中各项义务的能力。您应自行谨慎判断确定相关物品及/或信息的真实性、合法性和有效性，并自行承担因此产生的责任与损失。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>3.除非法律法规明确要求，或出现以下情况，否则，我公司没有义务对所有用户的注册数据、课程（服务）信息、交易行为以及与交易有关的其它事项进行事先审查：</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>a) 我公司有合理的理由认为特定会员及具体交易事项可能存在重大违法或违约情形。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>b) 我公司有合理的理由认为用户在我公司平台的行为涉嫌违法或不当。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>4.我公司及其关联公司有权受理您与其他会员因交易产生的争议，并有权单方判断与该争议相关的事实及应适用的规则，进而作出处理决定。该处理决定对您有约束力。如您未在限期内执行处理决定的，则我公司及其关联公司有权利（但无义务）直接使用您账户内的款项，或您向我公司及其关联公司交纳的保证金代为支付。您应及时补足保证金并弥补我公司及其关联公司的损失，否则我公司及其关联公司有权直接抵减您在其它合同项下的权益，并有权继续追偿。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;您理解并同意，我公司及其关联公司并非司法机构，仅能以普通人的身份对证据进行鉴别，我公司及其关联公司对争议的调处完全是基于您的委托，我公司及其关联公司无法保证争议处理结果符合您的期望，也不对争议调处结论承担任何责任。如您因此遭受损失，您同意自行向受益人索偿。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>5.您了解并同意，我公司不对因下述任一情况而导致您的任何损害赔偿承担责任，包括但不限于利润、商誉、使用、数据等方面的损失或其它无形损失的损害赔偿 (无论我公司是否已被告知该等损害赔偿的可能性) ：</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>a) 使用或未能使用我公司平台服务。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>b) 第三方未经批准的使用您的账户或更改您的数据。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>c) 通过我公司平台服务购买或获取任何课程、样品、数据、信息或进行交易等行为或替代行为产生的费用及损失。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>d) 您对我公司平台服务的误解。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>e) 任何非因我公司的原因而引起的与我公司平台服务有关的其它损失。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;6.不论在何种情况下，我公司均不对由于信息网络正常的设备维护，信息网络连接故障，电脑、通讯或其他系统的故障，电力故障，罢工，劳动争议，暴乱，起义，骚乱，生产力或生产资料不足，火灾，洪水，风暴，爆炸，战争，政府行为，司法行政机关的命令或第三方的不作为而造成的不能服务或延迟服务承担责任。</p>

                                
								<h3>六、 协议终止</h3>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>1.您同意，我公司有权自行全权决定以任何理由不经事先通知的中止、终止向您提供部分或全部我公司平台服务，暂时冻结或永久冻结（注销）您的账户，且无须为此向您或任何第三方承担任何责任。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>2.出现以下情况时，我公司有权直接以注销账户的方式终止本协议: </b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>a) 我公司终止向您提供服务后，您涉嫌再一次直接或间接或以他人名义注册为我公司用户的； </b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>b) 您提供的电子邮箱不存在或无法接收电子邮件，且没有其他方式可以与您进行联系，或我公司以其它联系方式通知您更改电子邮件信息，而您在我公司通知后三个工作日内仍未更改为有效的电子邮箱的。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>c) 您注册信息中的主要内容不真实或不准确或不及时或不完整。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>d) 本协议（含规则）变更时，您明示并通知我公司不愿接受新的服务协议的；</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;<b>e) 其它我公司认为应当终止服务的情况。 3.您有权向我公司要求注销您的账户，经我公司审核同意的，我公司注销（永久冻结）您的账户，届时，您与我公司基于本协议的合同关系即终止。您的账户被注销（永久冻结）后，我公司没有义务为您保留或向您披露您账户中的任何信息，也没有义务向您或第三方转发任何您未曾阅读或发送过的信息。</b></p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;4.您同意，您与我公司的合同关系终止后，我公司仍享有下列权利 </p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;a) 继续保存您的注册信息及您使用我公司平台服务期间的所有交易信息。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;b) 您在使用我公司平台服务期间存在违法行为或违反本协议和/或规则的行为的，我公司仍可依据本协议向您主张权利。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;5.我公司中止或终止向您提供我公司平台服务后，对于您在服务中止或终止之前的交易行为依下列原则处理，您应独力处理并完全承担进行以下处理所产生的任何争议、损失或增加的任何费用，并应确保我公司免于因此产生任何损失或承担任何费用： </p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;a) 您在服务中止或终止之前已经上传至我公司平台的物品尚未交易的，我公司有权在中止或终止服务的同时删除此项物品的相关信息； </p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;b) 您在服务中止或终止之前已经与其他会员达成买卖合同，但合同尚未实际履行的，我公司有权删除该买卖合同及其交易物品的相关信息；</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;c) 您在服务中止或终止之前已经与其他会员达成买卖合同且已部分履行的，我公司可以不删除该项交易，但我公司有权在中止或终止服务的同时将相关情形通知您的交易对方。 </p>
                                
								<h3>七、隐私权政策</h3>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;我公司将在我公司平台公布并不时修订隐私权政策，隐私权政策构成本协议的有效组成部分。</p>
                                
								<h3>八、法律适用、管辖与其他 </h3>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;1.本协议之效力、解释、变更、执行与争议解决均适用中华人民共和国法律，如无相关法律规定的，则应参照通用国际商业惯例和（或）行业惯例。</p>
                                <p>&nbsp;&nbsp;&nbsp;&nbsp;2.因本协议产生之争议，应依照中华人民共和国法律予以处理，并以我公司所在地有管辖权的法院进行管辖。</p>
                                <br />
                            </div>
							<div class="agreeBt" style="margin-top:10px;">
                                    <a>
                                        <asp:Button ID="btnBack" runat="server" class="button15"   onclick="btnBack_Click" />　<asp:Button  
                                        ID="btnPub" runat="server" class="button16" onclick="btnPub_Click"  /></a>
							</div>
						</div>
					</div>
</div>


</div>
</div>
</div>
</div>
</div>
<!-- end input5 -->

</div>
<!-- end main -->
</asp:Content>
