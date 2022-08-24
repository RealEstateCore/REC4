[Point](../../../../Point.md) > [Alarm](../../../Alarm.md) > [Air_Alarm](../../Air_Alarm.md) > [Air_Flow_Alarm](../Air_Flow_Alarm.md) > [Low_Air_Flow_Alarm](Low_Air_Flow_Alarm.md) > [Low_Supply_Air_Flow_Alarm](.)
# Low_Supply_Air_Flow_Alarm
**DTMI:** dtmi:org:brickschema:schema:Brick:Low_Supply_Air_Flow_Alarm;1
## Display name
- **en:** Low Supply Air Flow Alarm
## Description
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint