# Point
**DTMI:** dtmi:org:brickschema:schema:Brick:Point;1
## Display name
- **en:** Point
## Description
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|isPointOf|**en**: Is point of||0-Infinity|||True|
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|aggregate|**en**: Aggregate||TBD|True|
|customTags|**en**: Custom Tags||TBD|True|
|externalIds|**en**: External IDs||TBD|True|
|hasQuantity|**en**: has quantity||TBD|True|
|hasSubstance|**en**: has substance||TBD|True|
|lastKnownValue|**en**: Last known value||TBD|True|
|name|**en**: name||TBD|True|
## Target Of
### Direct
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
