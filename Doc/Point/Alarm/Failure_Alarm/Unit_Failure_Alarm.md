[Point](../../Point.md) > [Alarm](../Alarm.md) > [Failure_Alarm](Failure_Alarm.md) > [Unit_Failure_Alarm](.)
# Unit_Failure_Alarm

**Display name:** Unit Failure Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Unit_Failure_Alarm;1

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
