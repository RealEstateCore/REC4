# ServiceObject
**DTMI:** dtmi:org:w3id:rec:ServiceObject;1
## Display name
- **en:** Service object
## Description
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|acknowledgedBy|**en**: acknowledged by||0-1|dtmi:org:w3id:rec:Agent;1||True|
|closedBy|**en**: closed by||0-1|dtmi:org:w3id:rec:Agent;1||True|
|createdBy|**en**: created by||0-1|dtmi:org:w3id:rec:Agent;1||True|
|producedBy|**en**: produced by||0-Infinity|dtmi:org:brickschema:schema:Brick:Point;1||True|
|relatedTo|**en**: related to||0-Infinity|||True|
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|acknowledgedTime|**en**: acknowledged time||TBD|True|
|closedTime|**en**: closed time||TBD|True|
|createdTime|**en**: created time||TBD|True|
|severity|**en**: severity||TBD|True|
|status|**en**: status||TBD|True|
### Inherited Properties
* **dtmi:org:w3id:rec:Information;1:** customTags, externalIds, name
