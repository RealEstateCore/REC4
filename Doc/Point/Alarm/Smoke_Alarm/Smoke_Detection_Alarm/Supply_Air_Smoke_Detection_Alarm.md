[Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Smoke_Alarm](../Smoke_Alarm.md) > [Smoke_Detection_Alarm](Smoke_Detection_Alarm.md) > [Supply_Air_Smoke_Detection_Alarm](.)
# Supply_Air_Smoke_Detection_Alarm

**Display name:** Supply Air Smoke Detection Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Supply_Air_Smoke_Detection_Alarm;1

---
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
