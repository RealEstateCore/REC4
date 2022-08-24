[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Current_Sensor](../Current_Sensor.md) > [Current_Output_Sensor](Current_Output_Sensor.md) > [PV_Current_Output_Sensor](#)
# PV_Current_Output_Sensor

**Display name:** PV Current Output Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:PV_Current_Output_Sensor;1

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
